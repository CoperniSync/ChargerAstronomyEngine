using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Contracts.Repositories;
using ChargerAstronomyShared.Domain;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Heat;
using ChargerAstronomyShared.Domain.Horizontal;
using ChargerAstronomyShared.Domain.Index;
using ChargerAstronomyShared.Domain.SpatialIndex;

namespace ChargerAstronomyEngine.Streaming
{
    public class EngineService : IEngineService
    {
        HeatService heatService;
        HeatMap heatMap;
        HeatConfig heatConfig;

        ITileIndex tileIndex;

        private EquatorialCalculator equatorialCalculator;
        private SpatialStarIndex spatialStarIndex;


        private readonly BlockingCollection<TileId> activationQueue; 
        private readonly BlockingCollection<TileId> deactivationQueue;

        private readonly BlockingCollection<TileId> updateTransformQueue; // unity will remove from this queue

        public BlockingCollection<TileId> ActivationQueue => activationQueue;

        public BlockingCollection<TileId> DeactivationQueue => deactivationQueue;

        public BlockingCollection<TileId> UpdateTransformQueue => updateTransformQueue;

        public EngineService(ITileIndex tileIndex)
        {
            this.tileIndex = tileIndex;

            HeatMap heatMap = new HeatMap(new HeatConfig());

            heatService = new HeatService(heatMap, tileIndex);
            spatialStarIndex = new SpatialStarIndex(tileIndex);
            equatorialCalculator = new EquatorialCalculator(heatService, spatialStarIndex);

            activationQueue = new BlockingCollection<TileId>();
            deactivationQueue = new BlockingCollection<TileId>();
            updateTransformQueue = new BlockingCollection<TileId>();
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

        public void UpdateTimeAndLocation(CalendarDateTime newTime, Observer newLocation)
        {
            equatorialCalculator.UpdateTimeAndLocation(newTime, newLocation);
        }

        private void Update()
        {
            // continously running on a thread

            Task.Run(() =>
            {
                foreach (TileId tile in heatService.GetHeatMap().TilesAbove(0f))
                {
                    foreach (HorizontalStar star in spatialStarIndex.GetStarsInTile(tile))
                        equatorialCalculator.UpdateStar(star);

                    updateTransformQueue.Add(tile);
                }
            });

            Task.Run(() =>
            {
                foreach (var tile in heatMap.InactiveTilesAboveZero())
                {
                    tile.active = true; 
                    activationQueue.Add(tile);
                }
                foreach (var tile in heatMap.ActiveTileAtZero())
                {
                    tile.active = false;
                    deactivationQueue.Add(tile);
                }
            });
        }
     }
}
