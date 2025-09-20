using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using ChargerAstronomyEngine.Data;
using ChargerAstronomyEngine.Streaming;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Domain.Equatorial;

using FluentAssertions;
using Xunit;

namespace ChargerAstronomyEngine.Tests;
public class CsvStarRepository_ProducePagesAsync_Tests
{

    // AllStars contains all of the stars. Over 30k stars.
    // SmallStars is very small, only 2k stars.
    private static string FindCsvPath(string fileName = "AllStars" + ".csv")
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

        throw new FileNotFoundException($"Could not locate '{fileName}'. " +
            "Mark it as Content -> Copy if newer, or place it next to the test binaries.");
    }

    private static CsvStarRepository MakeRepo()
        => new(FindCsvPath());

    /// <summary>
    /// Produces pages of size 'Take' (final page may be short) and completes the queue.
    /// </summary>
    [Fact]
    public async Task ProducePagesAsync_ProducesPages_ThenCompletes()
    {
        // Arrange
        var repo = MakeRepo();
        var page = new PageRequest(skip: 0, take: 10);
        var queue = new BoundedInitializationQueue<PageResult<EquatorialStar>>(capacity: 5);

        // Act
        _ = Task.Run(() => repo.ProducePagesAsync(queue, page, CancellationToken.None));

        // Consume until producer signals completion and queue is drained
        var pages = new List<PageResult<EquatorialStar>>();
        while (true)
        {
            if (queue.TryDequeue(out var pr))
            {
                pages.Add(pr);
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

        // Assert
        pages.Should().NotBeEmpty("CSV should yield at least one page");
        queue.IsCompleted.Should().BeTrue("producer calls Complete() in finally");
    }

}
