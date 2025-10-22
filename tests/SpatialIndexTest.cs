using ChargerAstronomyEngine.Data.Star;
using ChargerAstronomyEngine.Streaming;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Index;
using ChargerAstronomyShared.Domain.SpatialIndex;
using FluentAssertions;
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Xunit;

namespace tests
{
    public class SpatialIndexTest
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

        /// <summary>
        /// Small test to ensure the IcosphereTileIndex returns an ID when given a valid direction.
        /// </summary>
        [Fact]
        public void DirectionToTileId_ReturnsId_ForValidDirection()
        {
            // Arrange
            var icosphereTileIndex = new IcosphereTileIndex();
            var direction = new Vector3(1, 0, 0); // Example direction vector pointing along the X-axis

            // Act
            var result = icosphereTileIndex.DirectionToTileId(direction);

            // Assert
            result.Should().NotBeNull("A valid TileId should be returned for a valid direction");
        }

        /// <summary>
        /// Small test to ensure the IcosphereTileIndex throws an error when given an invalid direction.
        /// </summary>
        [Fact]
        public void DirectionToTileId_ThrowsError_ForInvalidDirection()
        {
            // Arrange
            var icosphereTileIndex = new IcosphereTileIndex();
            var invalidDirection = new Vector3(0, 0, 0); // Invalid direction vector

            // Act
            Action act = () => icosphereTileIndex.DirectionToTileId(invalidDirection);

            // Assert
            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Tile for direction * not found");
        }

        /// <summary>
        /// Test to ensure DirectionToTileId returns the correct TileId for a specific direction.
        /// </summary>
        [Fact]
        public void DirectionToTileId_ReturnsCorrectId_ForSpecificDirection()
        {
            // Arrange
            var icosphereTileIndex = new IcosphereTileIndex();

            // Test each tile's center vector to ensure it maps back to the correct TileId
            foreach (var tile in icosphereTileIndex.Tiles)
            {
                var geometry = icosphereTileIndex.GetGeometry(tile);
                var direction = geometry.Center;
                // Act
                var result = icosphereTileIndex.DirectionToTileId(direction);
                // Assert
                result.Should().Be(tile, $"The TileId for direction {direction} should be {tile}.");
            }
        }

        /// <summary>
        /// Test that a SpatialStarIndex can be constructed from a stars CSV file.
        /// </summary>
        [Fact]
        public void SpatialStarIndex_CanBeConstructed_FromSmallStarsFile()
        {
            // Arrange
            var stars = new CsvStarRepository(FindCsvPath("SmallStars")).GetAllSync();

            // Act
            var starIndex = new SpatialStarIndex(new IcosphereTileIndex(), stars);

            // Assert
            starIndex.Should().NotBeNull("SpatialStarIndex should be constructed successfully from small stars file.");
        }

        /// <summary>
        /// Test that GetTileForStar returns a valid TileId for a given star.
        /// </summary>
        [Fact]
        public void SpatialStarIndex_GetTileForStar_ReturnsValidTileId()
        {
            // Arrange
            var stars = new CsvStarRepository(FindCsvPath("SmallStars")).GetAllSync();
            var starIndex = new SpatialStarIndex(new IcosphereTileIndex(), stars);
            var testStar = stars.First();

            // Act
            var tileId = starIndex.GetTileForStar(testStar);

            // Assert
            tileId.Should().NotBeNull("GetTileForStar should return a valid TileId for a given star.");
        }

        /// <summary>
        /// Test that GetStarsInTile returns stars that actually belong to the specified tile.
        /// </summary>
        [Fact]
        public void SpatialStarIndex_GetStarsInTile_ReturnsExpectedStars()
        {
            // Arrange
            var stars = new CsvStarRepository(FindCsvPath("SmallStars")).GetAllSync();
            var starIndex = new SpatialStarIndex(new IcosphereTileIndex(), stars);

            var testStars = stars.Take(5).ToList();
            var tiles = testStars.Select(star => starIndex.GetTileForStar(star)).ToList();

            // Act & Assert
            for (int i = 0; i < testStars.Count; i++)
            {
                var starsInTile = starIndex.GetStarsInTile(tiles[i]).ToList();
                var containsStar = starsInTile.Any(star => star.StarId == testStars[i].StarId);

                containsStar.Should().BeTrue($"The star with ID {testStars[i].StarId} should be present in the list of stars for its tile.");
            }
        }
    }
}
