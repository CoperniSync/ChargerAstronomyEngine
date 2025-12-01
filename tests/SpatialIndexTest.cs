using ChargerAstronomyEngine.Data.Star;
using ChargerAstronomyEngine.Streaming;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Horizontal;
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
        private List<TestStar> stars;
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

        public SpatialIndexTest()
        {
            var equatorialStars = new CsvStarRepository(FindCsvPath("AllStars")).GetAllSync();
            stars = equatorialStars.Select(s => new TestStar(s)).ToList();
        }


        // ALL THE TESTS BELOW WERE WRITTEN BY AI ( or by Jojo ), so I cant garuntee they do anything useful




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
        /// Test that a <see cref="SpatialStarIndex"/> can be constructed from a stars CSV file.
        /// </summary>
        [Fact]
        public void SpatialStarIndex_CanBeConstructed_FromSmallStarsFile()
        {

            // Act
            var starIndex = new SpatialStarIndex<TestStar>(new IcosphereTileIndex(), stars);

            // Assert
            starIndex.Should().NotBeNull("SpatialStarIndex should be constructed successfully from small stars file.");
        }

        /// <summary>
        /// Test that <see cref="SpatialStarIndex.GetTileForStar"/> returns a valid TileId for a given star.
        /// </summary>
        [Fact]
        public void SpatialStarIndex_GetTileForStar_ReturnsValidTileId()
        {

            var starIndex = new SpatialStarIndex<TestStar>(new IcosphereTileIndex(), stars);
            var testStar = stars.First();

            // Act
            var tileId = starIndex.GetTileForStar(testStar);

            // Assert
            tileId.Should().NotBeNull("GetTileForStar should return a valid TileId for a given star.");
        }

        /// <summary>
        /// Test that <see cref="SpatialStarIndex.GetStarsInTile"/> returns stars that actually belong to the specified tile.
        /// </summary>
        [Fact]
        public void SpatialStarIndex_GetStarsInTile_ReturnsExpectedStars()
        {
            var starIndex = new SpatialStarIndex<TestStar>(new IcosphereTileIndex(), stars);

            var testStars = stars.Take(5).ToList();
            var tiles = testStars.Select(star => starIndex.GetTileForStar(star)).ToList();

            // Act & Assert
            for (int i = 0; i < testStars.Count; i++)
            {
                var testStar = testStars[i].HorizontalBody as HorizontalStar;
                var starsInTile = starIndex.GetStarsInTile(tiles[i]).ToList();
                var containsStar = starsInTile.Any(star =>
                {
                    if (star.HorizontalBody is HorizontalStar horizontalStar && testStar != null)
                        return horizontalStar.StarId == testStar.StarId;
                    return false;
                });

                containsStar.Should().BeTrue($"The star with ID {testStar?.StarId : -1} should be present in the list of stars for its tile.");
            }
        }

        /// <summary>
        /// Tests that the <see cref="SpatialStarIndex.AddStar"/> method correctly adds a star to the appropriate tile.
        /// </summary>

        [Fact]
        public void SpatialStarIndex_AddStar_AddsStarToCorrectTile()
        {
            var starIndex = new SpatialStarIndex<TestStar>(new IcosphereTileIndex(), stars);
            var newStar = new TestStar(new EquatorialStar
            {
                StarId = 999999,
                RightAscension = 180.0,
                Declination = 0.0,
                Magnitude = 5.0
            });

            // Act
            starIndex.AddStar(newStar);

            var tileId = starIndex.GetTileForStar(newStar);
            var starsInTile = starIndex.GetStarsInTile(tileId);

            // Assert{
            starsInTile.Should().ContainSingle(star => 
                star.Equals(newStar), "The newly added star should be present in the correct tile.");
        }

        [Fact]
        public void DirectionToTileId_Debug_WhichTilesGetMapped()
        {
            var tileIndex = new IcosphereTileIndex(3);

            // Track how many times each tile gets hit
            var tileHitCount = new Dictionary<int, int>();
            var tilesMappedTo = new Dictionary<int, int>(); // original tile -> mapped tile

            foreach (var tileId in tileIndex.Enumerate())
            {
                var center = tileIndex.GetTileCenter(tileId);
                var mappedTile = tileIndex.DirectionToTileId(center);

                tilesMappedTo[tileId.Index] = mappedTile.Index;

                if (!tileHitCount.ContainsKey(mappedTile.Index))
                    tileHitCount[mappedTile.Index] = 0;
                tileHitCount[mappedTile.Index]++;
            }

            // Find tiles that got hit twice
            var doubleHitTiles = tileHitCount.Where(kvp => kvp.Value == 2).Select(kvp => kvp.Key).ToList();
            var neverHitTiles = tileIndex.Tiles.Select(t => t.Index).Except(tileHitCount.Keys).ToList();

            Console.WriteLine($"Tiles hit twice: {doubleHitTiles.Count}");
            Console.WriteLine($"Tiles never hit: {neverHitTiles.Count}");

            // Show some examples
            Console.WriteLine("\nFirst 10 tiles hit twice:");
            foreach (var tileIdx in doubleHitTiles.Take(10))
            {
                var stealers = tilesMappedTo.Where(kvp => kvp.Value == tileIdx).Select(kvp => kvp.Key).ToList();
                Console.WriteLine($"  Tile {tileIdx} was hit by tiles: {string.Join(", ", stealers)}");
            }

            Console.WriteLine("\nFirst 10 tiles never hit:");
            foreach (var tileIdx in neverHitTiles.Take(10))
            {
                var center = tileIndex.GetTileCenter(new TileId(tileIdx));
                var mappedTo = tilesMappedTo[tileIdx];
                Console.WriteLine($"  Tile {tileIdx} center {center} -> mapped to {mappedTo}");
            }
        }

        [Fact]
        public void DirectionToTileId_MapsToAllTiles()
        {
            var tileIndex = new IcosphereTileIndex(3);
            var hitTiles = new HashSet<int>();

            // Test with tile centers - each center should map back to its own tile
            foreach (var tileId in tileIndex.Enumerate())
            {
                var center = tileIndex.GetTileCenter(tileId);
                var mappedTile = tileIndex.DirectionToTileId(center);
                hitTiles.Add(mappedTile.Index);

                if (mappedTile.Index != tileId.Index)
                {
                    Console.WriteLine($"Tile {tileId.Index} center {center} mapped to tile {mappedTile.Index}");
                }
            }

            Console.WriteLine($"Unique tiles hit: {hitTiles.Count} / {tileIndex.TileCount}");

            hitTiles.Count.Should().Be(tileIndex.TileCount, "Every tile center should map to its own tile");
        }

        [Fact]
        public void TileCenters_CoverWholeSphere()
        {
            var tileIndex = new IcosphereTileIndex(3);

            var centers = tileIndex.Tiles.Select(t => tileIndex.GetTileCenter(t)).ToList();

            var minX = centers.Min(v => v.X);
            var maxX = centers.Max(v => v.X);
            var minY = centers.Min(v => v.Y);
            var maxY = centers.Max(v => v.Y);
            var minZ = centers.Min(v => v.Z);
            var maxZ = centers.Max(v => v.Z);

            Console.WriteLine($"Tile centers X range: {minX:F3} to {maxX:F3}");
            Console.WriteLine($"Tile centers Y range: {minY:F3} to {maxY:F3}");
            Console.WriteLine($"Tile centers Z range: {minZ:F3} to {maxZ:F3}");

            minX.Should().BeLessThan(-0.5f);
            maxX.Should().BeGreaterThan(0.5f);
            minY.Should().BeLessThan(-0.5f);
            maxY.Should().BeGreaterThan(0.5f);
            minZ.Should().BeLessThan(-0.5f);
            maxZ.Should().BeGreaterThan(0.5f);
        }

        /// <summary>
        /// Test that all tiles have at least some stars when using a large star set.
        /// This verifies stars are distributed across the sphere, not clustered.
        /// </summary>
        [Fact]
        public void SpatialStarIndex_AllTiles_HaveStars_WithSubdivisions()
        {
            // Arrange
            var tileIndex = new IcosphereTileIndex(3); // 1280 tiles
            var starIndex = new SpatialStarIndex<TestStar>(tileIndex, stars);

            int tilesWithStars = 0;
            int tilesWithoutStars = 0;
            var emptyTileIds = new List<int>();

            // Act
            foreach (var tileId in tileIndex.Enumerate())
            {
                var starsInTile = starIndex.GetStarsInTile(tileId);
                if (starsInTile.Count > 0)
                {
                    tilesWithStars++;
                }
                else
                {
                    tilesWithoutStars++;
                    emptyTileIds.Add(tileId.Index);
                }
            }

            // Assert
            Console.WriteLine($"Tiles with stars: {tilesWithStars}");
            Console.WriteLine($"Tiles without stars: {tilesWithoutStars}");
            Console.WriteLine($"Empty tile IDs (first 20): {string.Join(", ", emptyTileIds.Take(20))}");

            // With 15000+ stars across 1280 tiles, most tiles should have stars
            tilesWithoutStars.Should().BeLessThan(tileIndex.TileCount / 4,
                "Most tiles should have at least one star");
        }

        /// <summary>
        /// Test that ToUnitVector produces vectors covering the whole sphere.
        /// </summary>
        [Fact]
        public void Stars_UnitVectors_CoverWholeSphere()
        {
            // Convert stars to unit vectors the same way SpatialStarIndex does
            var vectors = stars.Select(s =>
            {
                var horizontal = s.HorizontalBody;
                double raRad = horizontal.RightAscension * 15.0f *  Math.PI / 180.0;
                double decRad = horizontal.Declination * Math.PI / 180.0;

                float x = (float)(Math.Cos(decRad) * Math.Cos(raRad));
                float y = (float)(Math.Cos(decRad) * Math.Sin(raRad));
                float z = (float)(Math.Sin(decRad));

                return Vector3.Normalize(new Vector3(x, y, z));
            }).ToList();

            var minX = vectors.Min(v => v.X);
            var maxX = vectors.Max(v => v.X);
            var minY = vectors.Min(v => v.Y);
            var maxY = vectors.Max(v => v.Y);
            var minZ = vectors.Min(v => v.Z);
            var maxZ = vectors.Max(v => v.Z);

            Console.WriteLine($"X range: {minX:F3} to {maxX:F3}");
            Console.WriteLine($"Y range: {minY:F3} to {maxY:F3}");
            Console.WriteLine($"Z range: {minZ:F3} to {maxZ:F3}");

            // Stars should cover most of the sphere
            minX.Should().BeLessThan(-0.5f, "Stars should cover negative X");
            maxX.Should().BeGreaterThan(0.5f, "Stars should cover positive X");
            minY.Should().BeLessThan(-0.5f, "Stars should cover negative Y");
            maxY.Should().BeGreaterThan(0.5f, "Stars should cover positive Y");
            minZ.Should().BeLessThan(-0.5f, "Stars should cover negative Z");
            maxZ.Should().BeGreaterThan(0.5f, "Stars should cover positive Z");
        }

        /// <summary>
        /// Test that DirectionToTileId returns consistent results for the same direction.
        /// </summary>
        [Fact]
        public void DirectionToTileId_IsConsistent_ForSameDirection()
        {
            var tileIndex = new IcosphereTileIndex(3);

            var testDirections = new[]
            {
        new Vector3(1, 0, 0),
        new Vector3(0, 1, 0),
        new Vector3(0, 0, 1),
        new Vector3(-1, 0, 0),
        new Vector3(0, -1, 0),
        new Vector3(0, 0, -1),
        new Vector3(0.577f, 0.577f, 0.577f), // Diagonal
    };

            foreach (var dir in testDirections)
            {
                var tile1 = tileIndex.DirectionToTileId(dir);
                var tile2 = tileIndex.DirectionToTileId(dir);

                tile1.Index.Should().Be(tile2.Index, $"Same direction {dir} should return same tile");

                Console.WriteLine($"Direction {dir} -> Tile {tile1.Index}");
            }
        }

        /// <summary>
        /// Test that every star's unit vector maps to a tile, and that tile contains the star.
        /// </summary>
        [Fact]
        public void EveryStar_MapsToTile_ThatContainsIt()
        {
            var tileIndex = new IcosphereTileIndex(3);
            var starIndex = new SpatialStarIndex<TestStar>(tileIndex, stars);

            int mismatches = 0;

            foreach (var star in stars.Take(100)) // Test first 100
            {
                var tileId = starIndex.GetTileForStar(star);
                var starsInTile = starIndex.GetStarsInTile(tileId);

                if (!starsInTile.Contains(star))
                {
                    mismatches++;
                    Console.WriteLine($"Star not found in its own tile! Tile: {tileId.Index}");
                }
            }

            mismatches.Should().Be(0, "Every star should be in the tile it maps to");
        }

        private class TestStar : IHorizontal
        {

            public TestStar (EquatorialStar equatorialStar)
            {
                HorizontalBody = new HorizontalStar(equatorialStar);
            }

            public override bool Equals(object? obj)
            {
                return obj is TestStar objTest && objTest.HorizontalBody is HorizontalStar objHor
                    && this.HorizontalBody is HorizontalStar thisHor && thisHor.StarId == objHor.StarId;
            }

            public void SetState(bool visible)
            {
                throw new NotImplementedException();
            }

            public void UpdatePosition()
            {
                throw new NotImplementedException();
            }

            public HorizontalBody HorizontalBody { get; }
        }
    }

   
}
