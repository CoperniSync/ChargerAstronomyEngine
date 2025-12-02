using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Contracts.Repositories;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Heat;
using ChargerAstronomyShared.Domain.Horizontal;
using ChargerAstronomyShared.Domain.Index;
using ChargerAstronomyShared.Domain.SpatialIndex;
using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyEngine.Domain.Heat;
using ChargerAstronomyShared.Domain;
using ChargerAstronomyShared.Contracts.Streaming;

namespace ChargerAstronomyEngine.Streaming
{

    /// <summary>
    /// Engine service. Manages star calculation, heat service, and spatial indexing.
    /// </summary>
    /// <typeparam name="T">The <see cref="ITileIndex"/> used in the current spatial index.</typeparam>
    public class EngineService<T> : IEngineService<T> where T : IHorizontal
    {
        private readonly HeatMap heatMap;
        private readonly HeatConfig heatConfig;
        private readonly ITileIndex tileIndex;
        private readonly EquatorialCalculator<T> equatorialCalculator;
        private readonly SpatialStarIndex<T> spatialStarIndex;
        private readonly HeatService heatService;
        private readonly Astronomy astronomy;

        private readonly BlockingCollection<T> activationQueue;
        private readonly BlockingCollection<T> deactivationQueue;
        private readonly BlockingCollection<T> updateTransformQueue;

        private readonly HashSet<TileId> activeTiles = new HashSet<TileId>();
        private readonly object activeTilesLock = new object();

        // track active stars with their magnitude for fast culling
        private readonly Dictionary<T, float> activeStarsWithMagnitude = new Dictionary<T, float>();

        // magnitude tracking
        private float currentMagnitudeCutoff = 6f;
        private float lastMagnitudeCutoff = 500f;
        private const float MAGNITUDE_CHANGE_THRESHOLD = 0.2f;

        // star update throttling
        private float timeSinceLastStarUpdate = 0f;
        private const float baseStarUpdateInterval = 0.45f;

        public HeatService HeatService => heatService;
        public SpatialStarIndex<T> SpatialStarIndex => spatialStarIndex;
        public BlockingCollection<T> ActivationQueue => activationQueue;
        public BlockingCollection<T> DeactivationQueue => deactivationQueue;
        public BlockingCollection<T> UpdateTransformQueue => updateTransformQueue;

        public EngineService(ITileIndex tileIndex)
        {
            this.tileIndex = tileIndex ?? throw new ArgumentNullException(nameof(tileIndex));

            astronomy = new Astronomy();
            heatConfig = new HeatConfig();
            heatMap = new HeatMap(heatConfig);

            // otherwise stars won't load properly
            foreach (var tileId in tileIndex.Enumerate())
            {
                heatMap.Set(tileId, 0f);
            }

            heatService = new HeatService(heatMap, tileIndex, astronomy);
            spatialStarIndex = new SpatialStarIndex<T>(tileIndex);
            equatorialCalculator = new EquatorialCalculator<T>(heatService, spatialStarIndex);

            activationQueue = new BlockingCollection<T>(new ConcurrentQueue<T>());
            deactivationQueue = new BlockingCollection<T>(new ConcurrentQueue<T>());
            updateTransformQueue = new BlockingCollection<T>(new ConcurrentQueue<T>());
        }

        /// <summary>
        /// Starts the engine calculator services.
        /// </summary>
        /// <returns>An <see cref="EquatorialCalculator{T}"/> instance.</returns>
        public IEquatorialCalculator StartServices()
        {
            return equatorialCalculator;
        }


        /// <inheritdoc />
        public void Step(float deltaTime, float camX, float camY, float camZ, float horizontalFOV, float magnitudeThreshold, float speedMult)
        {
            // Update magnitude cutoff
            currentMagnitudeCutoff = magnitudeThreshold;

            // Increment simulation time
            equatorialCalculator.IncrementTime(deltaTime);

            // Get current time and observer position for coordinate transformations
            equatorialCalculator.GetTimeAndPlace(out AstroTime time, out Observer observer);
            heatService.UpdateTimeAndLocation(time, observer);

            // Camera direction in horizontal space
            var cameraDirectionHorizontal = new System.Numerics.Vector3(camX, camY, camZ);
            cameraDirectionHorizontal = System.Numerics.Vector3.Normalize(cameraDirectionHorizontal);

            // Update heat map
            heatService.Step(deltaTime, cameraDirectionHorizontal, horizontalFOV).Wait();

            // Process tile activation/deactivation
            ProcessTileActivations();

            // Check if magnitude cutoff changed significantly
            if (Math.Abs(currentMagnitudeCutoff - lastMagnitudeCutoff) > MAGNITUDE_CHANGE_THRESHOLD)
            {
                ReEvaluateActiveTileMagnitudes();
                lastMagnitudeCutoff = currentMagnitudeCutoff;
            }

            // throttle star updates
            // there is no need to do so many every frame when you will barely notice
            float effectiveInterval = baseStarUpdateInterval / Math.Max(Math.Abs(speedMult), 0.1f);
            effectiveInterval = Math.Clamp(effectiveInterval, 0.1f, 2f);

            timeSinceLastStarUpdate += deltaTime;
            if (timeSinceLastStarUpdate >= effectiveInterval)
            {
                timeSinceLastStarUpdate = 0f;
                UpdateActiveStars();
            }
        }

        // re-evaluate active stars based on new magnitude cutoff

        /// <summary>
        /// Re-evaluates active tiles based on the current magnitude cutoff.
        /// </summary>
        private void ReEvaluateActiveTileMagnitudes()
        {
            float oldCutoff = lastMagnitudeCutoff;
            float newCutoff = currentMagnitudeCutoff;

            lock (activeTilesLock)
            {
                if (newCutoff < oldCutoff)
                {
                    var toRemove = activeStarsWithMagnitude
                        .Where(kvp => kvp.Value > newCutoff)
                        .Select(kvp => kvp.Key)
                        .ToList();

                    foreach (var star in toRemove)
                    {
                        activeStarsWithMagnitude.Remove(star);
                        deactivationQueue.TryAdd(star);
                    }
                }
                else
                {
                    foreach (var tileId in activeTiles)
                    {
                        try
                        {
                            var stars = spatialStarIndex.GetStarsInTile(tileId);
                            foreach (var star in stars)
                            {
                                float mag = (float)star.HorizontalBody.Magnitude;

                                if (mag > newCutoff) break;

                                // only activate stars in the new range (between old and new cutoff)
                                if (mag > oldCutoff && mag <= newCutoff)
                                {
                                    if (!activeStarsWithMagnitude.ContainsKey(star))
                                    {
                                        equatorialCalculator.UpdateStar(star);
                                        updateTransformQueue.TryAdd(star);

                                        activeStarsWithMagnitude[star] = mag;
                                        activationQueue.TryAdd(star);
                                    }
                                }
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            // tile doesn't exist, skip
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Processes tile activations and deactivations based on the heat map.
        /// </summary>
        private void ProcessTileActivations()
        {
            lock (activeTilesLock)
            {
                var shouldBeActive = new HashSet<TileId>(heatMap.TilesAbove(0.01f, inclusive: true));

                var toActivate = shouldBeActive.Except(activeTiles).ToList();
                var toDeactivate = activeTiles.Except(shouldBeActive).ToList();

                // activate tiles
                foreach (var tileId in toActivate)
                {
                    activeTiles.Add(tileId);

                    try
                    {
                        var stars = spatialStarIndex.GetStarsInTile(tileId);
                        foreach (var star in stars)
                        {
                            equatorialCalculator.UpdateStar(star);
                            updateTransformQueue.TryAdd(star);

                            float mag = (float)star.HorizontalBody.Magnitude;

                            if (mag > currentMagnitudeCutoff) break;

                            if (!activeStarsWithMagnitude.ContainsKey(star))
                            {
                                activeStarsWithMagnitude[star] = mag;
                                activationQueue.TryAdd(star);
                            }
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        continue;
                    }
                }

                // deactivate tiles
                foreach (var tileId in toDeactivate)
                {
                    activeTiles.Remove(tileId);

                    try
                    {
                        var stars = spatialStarIndex.GetStarsInTile(tileId);
                        foreach (var star in stars)
                        {
                            if (activeStarsWithMagnitude.Remove(star))
                            {
                                deactivationQueue.TryAdd(star);
                            }
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// Updates the positions of all active stars.
        /// </summary>
        private void UpdateActiveStars()
        {
            var starsToUpdate = activeStarsWithMagnitude.Keys.ToList();

            Parallel.ForEach(starsToUpdate, star =>
            {
                equatorialCalculator.UpdateStar(star);
                updateTransformQueue.TryAdd(star);
            });
        }

        /// <inheritdoc />
        public void ForceStarUpdate(T star)
        {
            equatorialCalculator.UpdateStar(star);
            updateTransformQueue.TryAdd(star);
        }

        /// <inheritdoc />
        public void PlaceStars()
        {
            Parallel.ForEach(tileIndex.Tiles, tileId =>
            {
                try
                {
                    var stars = spatialStarIndex.GetStarsInTile(tileId);
                    foreach (var star in stars)
                    {
                        equatorialCalculator.UpdateStar(star);
                        updateTransformQueue.TryAdd(star);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            });
        }

        /// <inheritdoc />
        public EngineStats GetStats()
        {
            lock (activeTilesLock)
            {
                return new EngineStats
                {
                    TotalTiles = tileIndex.TileCount,
                    ActiveTiles = activeTiles.Count,
                    TotalStars = spatialStarIndex.Stars.Count,
                    ActiveStars = activeStarsWithMagnitude.Count,
                    ActivationQueueSize = activationQueue.Count,
                    DeactivationQueueSize = deactivationQueue.Count,
                    UpdateQueueSize = updateTransformQueue.Count
                };
            }
        }
    }
}