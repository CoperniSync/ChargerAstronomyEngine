
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Contracts.Repositories;
using ChargerAstronomyShared.Contracts.Streaming;
using ChargerAstronomyShared.Domain.Equatorial;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;

namespace ChargerAstronomyEngine.Data
{

    public sealed class CsvStarRepository : IStarRepository
    {
        readonly string csvfilePath;

        public CsvStarRepository(string csvPath)
        {
            if (string.IsNullOrWhiteSpace(csvPath))
            {
                throw new ArgumentException("Need CSV file path", nameof(csvPath));
            }

            this.csvfilePath = csvPath;
        }

        // We likely don't need any of these methods. Can still provide filtering capabilities in the engine though it may be difficult.
        public async Task<PageResult<EquatorialStar>> GetAllAsync(PageRequest page)
        {
            throw new System.NotImplementedException();
        }

        public async Task<EquatorialStar> GetStarByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PageResult<EquatorialStar>> QueryBySkyRegionAsync(SkyRegion skyRegion, PageRequest page)
        {
            throw new System.NotImplementedException();
        }

        public async Task ProducePagesAsync(IInitializationQueue<PageResult<EquatorialStar>> queue, 
            PageRequest firstPage, CancellationToken cancellationToken = default)
        {
            if (queue == null) throw new ArgumentNullException(nameof(queue));
            if (!File.Exists(csvfilePath)) throw new ArgumentException("CSV file not found", nameof(csvfilePath));

            int skipped = 0;
            int produced = 0;
            var buffer = new List<EquatorialStar>(firstPage.Take);

            try
            {
                foreach (var star in EnumerateStars(csvfilePath, cancellationToken))
                {
                    if (skipped < firstPage.Skip)
                    {
                        skipped++;
                        continue;
                    }

                    buffer.Add(star);
                    produced++;

                    if (produced >= firstPage.Take)
                    {
                        EnqueuePage(queue, buffer, 0, firstPage.Skip + skipped, firstPage.Take, cancellationToken);
                        buffer.Clear();
                        produced = 0;

                        await Task.Yield();
                    }
                }

                if (buffer.Count > 0)
                    EnqueuePage(queue, buffer, 0, firstPage.Skip + skipped, firstPage.Take, cancellationToken);  
            }
            finally
            {
                queue.Complete();
            }
        }

        static IEnumerable<EquatorialStar> EnumerateStars(string csvfilePath, CancellationToken cancellationToken)
        {
            var config = GetCsvConfig();

            using var reader = new StreamReader(csvfilePath);
            using var csv = new CsvReader(reader, config);
            
            RegisterTypeOptions(csv);
            csv.Context.RegisterClassMap<EquatorialStarMap>();

            if (!csv.Read()) yield break;
            csv.ReadHeader();

            foreach(var record in csv.GetRecords<EquatorialStar>())
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (record.StarId > 0 ) // I'm not sure why we need this but prev codebase had it so i'll leave it here
                    yield return record;
            }
        }

        static void RegisterTypeOptions(CsvReader csv)
        {
            var d = csv.Context.TypeConverterOptionsCache.GetOptions<double>();
            d.CultureInfo = CultureInfo.InvariantCulture;

            var dn = csv.Context.TypeConverterOptionsCache.GetOptions<double?>();
            dn.CultureInfo = CultureInfo.InvariantCulture;

            // Leaving this here just incase if we use another data set and it has weird null values
            dn.NullValues.AddRange(new[] { "NULL", "N/A" });
        }

        static CsvConfiguration GetCsvConfig()
        {
            var config = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                TrimOptions = TrimOptions.Trim,
                HeaderValidated = null,
                MissingFieldFound = null,
                BadDataFound = null,
            };

            return config;
        }

        static void EnqueuePage(IInitializationQueue<PageResult<EquatorialStar>> queue,
            List<EquatorialStar> buffer,
            int total, 
            int skip,
            int take,
            CancellationToken cancellationToken)
        {
            var items = buffer.ToArray();
            var page = new PageResult<EquatorialStar>(items, total, skip, take);

            queue.EnqueueBlocking(page, cancellationToken);
        }

    }
}
