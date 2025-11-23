using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Domain.Heat;
using ChargerAstronomyShared.Domain.Index;
using ChargerAstronomyEngine.Data.Star;
using FluentAssertions;
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Xunit;

namespace tests
{
    public class HeatTests
    {
        private static string FindCsvPath(string fileName)
        {
            fileName = fileName + ".csv";
            var direct = Path.Combine(AppContext.BaseDirectory, fileName);
            if (File.Exists(direct)) return direct;

            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            for (int i = 0; i < 8 && dir != null; i++, dir = dir.Parent)
            {
                var candidate = Directory.EnumerateFiles(dir.FullName, fileName, SearchOption.AllDirectories)
                                         .FirstOrDefault();
                if (candidate != null) return candidate;
            }

            throw new FileNotFoundException($"Could not locate '{fileName}'. " +
                "Mark it as Content -> Copy if newer, or place it next to the test binaries.");
        }

        [Fact]  
        public void HeatMap_RetrievalMethods_Work()  
        {  
            // Arrange  
            var heatService = new HeatService(  
                new HeatMap(new HeatConfig()  
                {  
                    ClampMin = 0f,  
                    ClampMax = 10f,  
                    DecayPerSecond = 1f  
                }),  
                new IcosphereTileIndex()  
            );  

            var heatMap = heatService.GetHeatMap();  
            var tileIndex = heatService.GetTileIndex();

            heatMap.Set(tileIndex.Tiles, 10f);

            // Act
            heatMap.Set(tileIndex.Tiles.Take(5), 5.0f);  // Lower the heat of the first 5 tiles to 5.0f
            var tilesAbove = heatMap.TilesAbove(8.0f);
            var tilesBelow = heatMap.TilesBelow(6.0f);
            var tilesInRange = heatMap.TilesInRange(5.0f, 10.0f, false);

            // Assert
            tilesAbove.Should().NotContain(tileIndex.Tiles.Take(5));
            tilesBelow.Should().NotContain(tilesAbove);
            tilesInRange.Should().BeEmpty();
        }

        [Fact]
        public void HeatService_Step_UpdatesHeatMapCorrectly()
        {
            // Arrange
            var heatService = new HeatService(
                new HeatMap(new HeatConfig()
                {
                    ClampMin = 0f,
                    ClampMax = 10f,
                    DecayPerSecond = 1f
                }),
                new IcosphereTileIndex()
            );
            var heatMap = heatService.GetHeatMap();
            var tileIndex = heatService.GetTileIndex();

            heatMap.Set(tileIndex.Tiles, 10f);

            // Act
            //heatService.Step(1.0f);

            // ASSERT NOT FINISHED
        }
    }
}
