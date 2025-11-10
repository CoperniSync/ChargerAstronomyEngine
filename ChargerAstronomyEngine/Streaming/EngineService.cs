using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Contracts.Repositories;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Heat;
using ChargerAstronomyShared.Domain.Horizontal;
using ChargerAstronomyShared.Domain.Index;
using ChargerAstronomyShared.Domain.SpatialIndex;

namespace ChargerAstronomyEngine.Streaming
{
    public class EngineService<T> : IEngineService<T> where T : IHorizontal
    {
        HeatMap heatMap;
        HeatConfig heatConfig;

        ITileIndex tileIndex;

        EquatorialCalculator<T> equatorialCalculator;
        SpatialStarIndex<T> spatialStarIndex;
        HeatService heatService;


        private readonly BlockingCollection<T> activationQueue; 
        private readonly BlockingCollection<T> deactivationQueue;

        private readonly BlockingCollection<T> updateTransformQueue; // unity will remove from this queue

        public HeatService HeatService => heatService;
        public SpatialStarIndex<T> SpatialStarIndex => spatialStarIndex;

        public BlockingCollection<T> ActivationQueue => activationQueue;

        public BlockingCollection<T> DeactivationQueue => deactivationQueue;

        public BlockingCollection<T> UpdateTransformQueue => updateTransformQueue;

        public EngineService(ITileIndex tileIndex)
        {
            this.tileIndex = tileIndex;

            HeatMap heatMap = new HeatMap(new HeatConfig());

            heatService = new HeatService(heatMap, tileIndex);
            spatialStarIndex = new SpatialStarIndex<T>(tileIndex);
            equatorialCalculator = new EquatorialCalculator<T>(heatService, spatialStarIndex);

            activationQueue = new BlockingCollection<T>();
            deactivationQueue = new BlockingCollection<T>();
            updateTransformQueue = new BlockingCollection<T>();
        }

        public IEquatorialCalculator StartServices()
        {

            return equatorialCalculator;
        }

        public async Task Step(float deltaTime, Vector3 cameraDirection, float horizontalFOV)
        {
            equatorialCalculator.IncrementTime(deltaTime);

            await heatService.Step(deltaTime, cameraDirection, horizontalFOV);
            
            Update();
        }

        private void Update()
        {
            // continously running on a thread

            Task.Run(() =>
            {
                foreach (TileId tile in heatService.GetHeatMap().TilesAbove(0f))
                {
                    foreach (var star in spatialStarIndex.GetStarsInTile(tile))
                    {
                        equatorialCalculator.UpdateStar(star);
                        updateTransformQueue.Add(star);
                    }
                }
            });

            Task.Run(() =>
            {
                foreach (var tile in heatMap.InactiveTilesAboveZero())
                {
                    tile.active = true; 
                    foreach (var star in spatialStarIndex.GetStarsInTile(tile))
                        activationQueue.Add(star);

                }
                foreach (var tile in heatMap.ActiveTileAtZero())
                {
                    tile.active = false;
                    foreach (var star in spatialStarIndex.GetStarsInTile(tile))
                        deactivationQueue.Add(star);
                }
            });
        }
     }
}
