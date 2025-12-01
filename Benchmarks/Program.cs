using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ChargerAstronomyEngine.Data.Star;
using ChargerAstronomyEngine.Streaming;
using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Domain.Horizontal;
using ChargerAstronomyShared.Domain.Index;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain;

namespace ChargerAstronomyEngine.Benchmarking
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("-        Stargazer Engine Benchmarks                     -");
            Console.WriteLine("----------------------------------------------------------\n");

            int framesToRun = 1000;
            int maxStars = 31000;

            // Since I want to store the directory in the project folder instead of bin we have to do this
            var projectDir = Directory.GetParent(AppContext.BaseDirectory)!
                                        .Parent!   
                                        .Parent!  
                                        .Parent!   
                                        .FullName;

            string outputDir = Path.Combine(projectDir, "benchmark_results");

            if (args.Contains("--frames") && args.Length > Array.IndexOf(args, "--frames") + 1)
                framesToRun = int.Parse(args[Array.IndexOf(args, "--frames") + 1]);

            Console.WriteLine($"Config:");
            Console.WriteLine($"  Frames: {framesToRun}");
            Console.WriteLine($"  Max Stars: {maxStars}");
            Console.WriteLine($"  Output: {outputDir}\n");

            Console.WriteLine("Loading stars from CSV...");
            var stars = await LoadStarsAsync(maxStars);
            Console.WriteLine($"Loaded {stars.Count} stars\n");

            Directory.CreateDirectory(outputDir);

            RunBenchmark("LatLong", new UVSphereTileIndex(34, 28), stars, framesToRun, outputDir);
            Console.WriteLine();

            RunBenchmark("CubeMap", new CubeMapTileIndex(7), stars, framesToRun, outputDir);
            Console.WriteLine();

            RunBenchmark("Icosphere", new IcosphereTileIndex(2), stars, framesToRun, outputDir);
            Console.WriteLine();

            Console.WriteLine($"\nFinished");
            Console.WriteLine($"Results : {outputDir}/");
            Console.ReadKey();
        }

        static void RunBenchmark(string methodName, ITileIndex tileIndex, List<IHorizontal> stars, int frames, string outputDir)
        {
            Console.WriteLine($"---- {methodName} ----");
            Console.WriteLine($"Tiles: {tileIndex.TileCount}");

            Console.Write("  Testing tile lookup speed... ");
            float avgLookupTime = MeasureTileLookupPerformance(tileIndex);
            Console.WriteLine($"{avgLookupTime:F6}ms avg");

            var engine = new EngineService<IHorizontal>(tileIndex);

            foreach (var star in stars)
            {
                engine.SpatialStarIndex.AddStar(star);
            }
            engine.SpatialStarIndex.SortAllTilesByMagnitude();

            var equatorialCalc = engine.StartServices();
            var observer = new Observer(38.0, -90.0, 0.0); 
            var startTime = new CalendarDateTime(2025, 1, 1, 20, 0, 0);
            equatorialCalc.UpdateTimeAndLocation(startTime, observer);


            float azimuth = 0f;
            float altitude = 0f;
            float rotationSpeed = 15f; // degrees per second 
            float deltaTime = 1f / 60f; // 60 FPS

            int framesPerSweep = 200; 

            // data collection
            var csvData = new List<string>();
            csvData.Add("Frame,Timestamp,StarsUpdated,ActiveTiles,FrameTimeMs,Azimuth,Altitude");

            var stopwatch = new Stopwatch();

            // measure initial memory footprint
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            long memoryBefore = GC.GetTotalMemory(false);

            // run simulation
            for (int frame = 0; frame < frames; frame++)
            {
                stopwatch.Restart();

                // Gotta go from 0 to 90 degrees
                int sweepPosition = frame % framesPerSweep;
                altitude = (sweepPosition / (float)framesPerSweep) * 90f;

                azimuth += rotationSpeed * deltaTime;
                if (azimuth >= 360f) azimuth -= 360f;

                float altRad = altitude * MathF.PI / 180f;
                float azRad = azimuth * MathF.PI / 180f;
                float x = MathF.Cos(altRad) * MathF.Sin(azRad);
                float y = MathF.Cos(altRad) * MathF.Cos(azRad);
                float z = MathF.Sin(altRad);

                // run engine step and measure total time
                engine.Step(
                    deltaTime,
                    x, y, z,
                    horizontalFOV: 60f,
                    magnitudeThreshold: 6.0f,
                    speedMult: 1.0f
                );

                stopwatch.Stop();

                var stats = engine.GetStats();
                float frameTimeMs = (float)stopwatch.Elapsed.TotalMilliseconds;

                csvData.Add($"{frame},{frame * deltaTime:F3},{stats.ActiveStars},{stats.ActiveTiles},{frameTimeMs:F3},{azimuth:F1},{altitude:F1}");

                // progress
                if ((frame + 1) % 100 == 0)
                    Console.Write($"\r  Progress: {frame + 1}/{frames}");
            }

            Console.WriteLine($"\r  Progress: {frames}/{frames}");

            Console.WriteLine("\n  Altitude:");
            var altitudeBuckets = new Dictionary<string, List<int>>();
            altitudeBuckets["Equator"] = new List<int>();
            altitudeBuckets["MidLat"] = new List<int>();
            altitudeBuckets["HighLat"] = new List<int>();
            altitudeBuckets["Polar"] = new List<int>();

            for (int i = 1; i < csvData.Count; i++)
            {
                var parts = csvData[i].Split(',');
                float alt = float.Parse(parts[6]);
                int count = int.Parse(parts[2]);

                if (alt < 30) altitudeBuckets["Equator"].Add(count);
                else if (alt < 60) altitudeBuckets["MidLat"].Add(count);
                else if (alt < 80) altitudeBuckets["HighLat"].Add(count);
                else altitudeBuckets["Polar"].Add(count);
            }

            foreach (var bucket in altitudeBuckets)
            {
                if (bucket.Value.Count > 0)
                {
                    Console.WriteLine($"    {bucket.Key}: Avg={bucket.Value.Average():F0}, " + $"Max={bucket.Value.Max()}, Count={bucket.Value.Count}");
                }
            }

            string csvPath = Path.Combine(outputDir, $"{methodName}_frames.csv");
            File.WriteAllLines(csvPath, csvData);
            Console.WriteLine($"  Saved: {csvPath}");

            // measure final memory
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            long memoryAfter = GC.GetTotalMemory(false);
            long memoryUsed = memoryAfter - memoryBefore;

            var starsUpdated = csvData.Skip(1).Select(line => int.Parse(line.Split(',')[2])).ToList();
            var activeTiles = csvData.Skip(1).Select(line => int.Parse(line.Split(',')[3])).ToList();
            var frameTimes = csvData.Skip(1).Select(line => float.Parse(line.Split(',')[4])).ToList();

            var summary = new System.Text.StringBuilder();
            summary.AppendLine($"{methodName} Summary:");
            summary.AppendLine($"  Total Tiles: {tileIndex.TileCount}");
            summary.AppendLine($"  Tile Lookup Time: {avgLookupTime:F6} ms (avg per lookup)");
            summary.AppendLine($"  Memory Footprint: {memoryUsed / 1024.0 / 1024.0:F2} MB");
            summary.AppendLine($"  Stars Updated:");
            summary.AppendLine($"    Avg: {starsUpdated.Average():F1}");
            summary.AppendLine($"    Min: {starsUpdated.Min()}");
            summary.AppendLine($"    Max: {starsUpdated.Max()}");
            summary.AppendLine($"    StdDev: {StandardDeviation(starsUpdated):F1}");
            summary.AppendLine($"  Active Tiles:");
            summary.AppendLine($"    Avg: {activeTiles.Average():F1}");
            summary.AppendLine($"    Min: {activeTiles.Min()}");
            summary.AppendLine($"    Max: {activeTiles.Max()}");
            summary.AppendLine($"    StdDev: {StandardDeviation(activeTiles.Select(x => (int)x).ToList()):F1}");
            summary.AppendLine($"  Frame Time (ms):");
            summary.AppendLine($"    Avg: {frameTimes.Average():F3}");
            summary.AppendLine($"    Min: {frameTimes.Min():F3}");
            summary.AppendLine($"    Max: {frameTimes.Max():F3}");
            summary.AppendLine($"    95th Percentile: {Percentile(frameTimes, 0.95f):F3}");

            string summaryPath = Path.Combine(outputDir, $"{methodName}_summary.txt");
            File.WriteAllText(summaryPath, summary.ToString());
            Console.WriteLine($"  Summary: {summaryPath}");
        }

        static async Task<List<IHorizontal>> LoadStarsAsync(int maxStars)
        {
            var stars = new List<IHorizontal>();
            var csvPath = FindCsvPath("AllStars.csv");

            var repo = new CsvStarRepository(csvPath);
            var queue = new BoundedInitializationQueue<PageResult<EquatorialStar>>(capacity: 5);
            var pageRequest = new PageRequest(skip: 0, take: maxStars);

            _ = Task.Run(() => repo.ProducePagesAsync(queue, pageRequest, CancellationToken.None));

            int loaded = 0;
            while (true)
            {
                if (queue.TryDequeue(out var page))
                {
                    foreach (var equatorialStar in page.Items)
                    {
                        // wrap in BenchmarkStar (implements IHorizontal but does nothing, (sadly we need spatialstarindex to use ihorizontal for unity stuff))
                        var benchmarkStar = new BenchmarkStar(equatorialStar);
                        stars.Add(benchmarkStar);
                        loaded++;
                    }
                    Console.Write($"\r  Loading... {loaded:N0}");
                }
                else if (queue.IsCompleted)
                {
                    break;
                }
                else
                {
                    await Task.Delay(1);
                }
            }
            Console.WriteLine($"\r  Loading... {loaded:N0}");

            return stars;
        }

        static string FindCsvPath(string fileName)
        {
            var direct = Path.Combine(AppContext.BaseDirectory, fileName);
            if (File.Exists(direct)) return direct;

            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            for (int i = 0; i < 8 && dir != null; i++, dir = dir.Parent)
            {
                var candidate = Directory.EnumerateFiles(dir.FullName, fileName, SearchOption.AllDirectories)
                    .FirstOrDefault();
                if (candidate != null) return candidate;
            }

            throw new FileNotFoundException($"Could not locate '{fileName}'");
        }

        static double StandardDeviation(List<int> values)
        {
            if (values.Count < 2) return 0;
            double avg = values.Average();
            double sumSquaredDiff = values.Sum(v => (v - avg) * (v - avg));
            return Math.Sqrt(sumSquaredDiff / values.Count);
        }

        static float Percentile(List<float> values, float percentile)
        {
            var sorted = values.OrderBy(v => v).ToList();
            int index = (int)Math.Ceiling(sorted.Count * percentile) - 1;
            index = Math.Max(0, Math.Min(index, sorted.Count - 1));
            return sorted[index];
        }


        // Gotta run this seperately since ( althoguh engine.step does run this internally, it also runs other things so we can't test appropriately here ) 
        static float MeasureTileLookupPerformance(ITileIndex tileIndex)
        {
            const int iterations = 10000;
            var random = new Random(42);
            var stopwatch = new System.Diagnostics.Stopwatch();

            // generate random directions
            var directions = new System.Numerics.Vector3[iterations];
            for (int i = 0; i < iterations; i++)
            {
                float theta = (float)(random.NextDouble() * Math.PI * 2);
                float phi = (float)(Math.Acos(2 * random.NextDouble() - 1));
                directions[i] = new System.Numerics.Vector3(
                    MathF.Sin(phi) * MathF.Cos(theta),
                    MathF.Sin(phi) * MathF.Sin(theta),
                    MathF.Cos(phi)
                );
            }

            // measure
            stopwatch.Start();
            for (int i = 0; i < iterations; i++)
            {
                _ = tileIndex.DirectionToTileId(directions[i]);
            }
            stopwatch.Stop();

            return (float)stopwatch.Elapsed.TotalMilliseconds / iterations;
        }
    }
}