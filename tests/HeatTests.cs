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
            tilesAbove.Should().Contain(tileIndex.Tiles.Skip(5)).And.NotContain(tileIndex.Tiles.Take(5));
            tilesBelow.Should().Contain(tileIndex.Tiles.Take(5)).And.NotContain(tileIndex.Tiles.Skip(5));
            tilesInRange.Should().BeEmpty();
        }

        [Fact]
        public void HeatService_Step_UpdatesHeatMapBasedOnCameraView()
        {
            // Arrange
            var heatService = new HeatService(
                new HeatMap(new HeatConfig()
                {
                    ClampMin = 0f,
                    ClampMax = 1f,
                    DecayPerSecond = .05f
                }),
                new IcosphereTileIndex()
            );
            var heatMap = heatService.GetHeatMap();
            var tileIndex = heatService.GetTileIndex();

            var scratch = new List<TileId>();
            var visibleTiles = TileSelector.Select(
                tileIndex,
                new Vector3(1, 1, 1),
                45.0f * (float)(Math.PI / 180.0),
                scratch,
                false,
                0f
            );

            heatMap.Set(tileIndex.Tiles, 1.0f);

            // Act
            heatService.Step(1.0f);

            // Assert
            heatMap.TilesAbove(1.0f, true).Should().Contain(visibleTiles);
            heatMap.TilesBelow(1.0f, false).Should().NotContain(visibleTiles);
        }
    }
}
