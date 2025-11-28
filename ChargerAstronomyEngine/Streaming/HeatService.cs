using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Domain.Index;
using ChargerAstronomyShared.Domain.Coordinate;
using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyShared.Domain.Heat;
using ChargerAstronomyShared.Domain;

namespace ChargerAstronomyEngine.Domain.Heat
{
    public sealed class HeatService
    {
        public readonly HeatMap heatMap;
        public readonly ITileIndex index;
        private readonly List<TileId> scratch = new List<TileId>(capacity: 256);

        // we need these for coordinate transformation
        private AstroTime currentTime;
        private Observer currentObserver;
        private Astronomy astronomy;

        public HeatService(HeatMap heatMap, ITileIndex index, Astronomy astronomy)
        {
            this.heatMap = heatMap ?? throw new ArgumentNullException(nameof(heatMap));
            this.index = index ?? throw new ArgumentNullException(nameof(index));
            this.astronomy = astronomy ?? throw new ArgumentNullException(nameof(astronomy));
        }

        public void UpdateTimeAndLocation(AstroTime time, Observer observer)
        {
            currentTime = time;
            currentObserver = observer;
        }

        public HeatMap GetHeatMap() => heatMap;
        public ITileIndex GetTileIndex() => index;

        public async Task Step(float deltaTime, Vector3 cameraDirectionHorizontal, float horizontalFOV)
        {
            // apply decay to all tiles
            heatMap.StepDecay(deltaTime);

            // camera is in horizontal space, tiles are in equatorial space
            Vector3 cameraDirectionEquatorial = CoordinateTransform.HorizontalToEquatorial(
                cameraDirectionHorizontal,
                currentTime,
                currentObserver,
                astronomy
            );

            scratch.Clear();
            TileSelector.Select(index, cameraDirectionEquatorial, horizontalFOV, scratch, contains: false);

            // Add heat to visible tiles
            const float observedHeatValue = 1.0f;
            foreach (var tileId in scratch)
            {
                float currentHeat = heatMap.Get(tileId);
                if (currentHeat < observedHeatValue)
                {
                    heatMap.Set(tileId, observedHeatValue);
                }
            }
        }


        public IEnumerable<TileId> GetActiveTiles()
        {
            return heatMap.TilesAbove(0f, inclusive: false);
        }

        public IEnumerable<TileId> GetInactiveTiles()
        {
            return heatMap.TilesBelow(float.Epsilon, inclusive: true);
        }
    }
}