
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
using System.Diagnostics;

namespace ChargerAstronomyEngine.Data.Star
{
    /// <summary>
    /// Used to retrieve star data from a csv file.
    /// </summary>
    public sealed class CsvStarRepository : IStarRepository
    {

        /// <summary>
        /// The file path of the CSV file.
        /// </summary>
        readonly string csvfilePath;

        /// <summary>
        /// A repository of stars loaded from a CSV file.
        /// </summary>
        /// <param name="csvPath"></param>
        /// <exception cref="ArgumentException"></exception>
        public CsvStarRepository(string csvPath)
        {
            if (string.IsNullOrWhiteSpace(csvPath))
            {
                throw new ArgumentException("Need CSV file path", nameof(csvPath));
            }

            csvfilePath = csvPath;
        }

        /// <summary>
        /// Provides a synchronous way to get all stars from the CSV file.
        /// Used for testing only.
        /// </summary>
        /// <param name="csvFilePath"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        public IEnumerable<EquatorialStar> GetAllSync(CancellationToken cancellationToken = default)
        {
            return EnumerateStars(csvfilePath, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<PageResult<EquatorialStar>> GetAllAsync(PageRequest page)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<EquatorialStar> GetStarByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<PageResult<EquatorialStar>> QueryBySkyRegionAsync(SkyRegion skyRegion, PageRequest page)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task ProducePagesAsync(BlockingQueue<PageResult<EquatorialStar>> queue, 
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
            catch
            {
                Debug.Print("Exception in ProducePagesAsync, completing queue");
            }
            finally
            {
                queue.Complete();
            }
        }

        /// <summary>
        /// Enumerates stars from a CSV file, yielding each valid record as an <see cref="EquatorialStar"/> object.
        /// </summary>
        /// <remarks>The method reads the CSV file line by line and processes each record lazily. The caller can cancel the
        /// operation at any time by signaling the provided <paramref name="cancellationToken"/>.</remarks>
        /// <param name="csvfilePath">The path to the CSV file containing star data. The file must be in the expected format.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests. The operation will throw <see
        /// cref="OperationCanceledException"/> if cancellation is requested.</param>
        /// <returns>An enumerable collection of <see cref="EquatorialStar"/> objects representing the stars in the CSV file.</returns>
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

        /// <summary>
        /// Configures type conversion options for the <see cref="CsvReader"/> instance.
        /// </summary>
        /// <remarks>This method sets the <see cref="CultureInfo"/> for double and nullable double types
        /// to  <see cref="CultureInfo.InvariantCulture"/> to ensure consistent parsing of numeric values regardless of
        /// the system's culture settings. Additionally, it configures the handling of null values  for nullable double
        /// types by adding "NULL" and "N/A" as recognized null value representations.</remarks>
        /// <param name="csv">The <see cref="CsvReader"/> instance for which type conversion options are being configured.  This parameter
        /// cannot be null.</param>
        static void RegisterTypeOptions(CsvReader csv)
        {
            var d = csv.Context.TypeConverterOptionsCache.GetOptions<double>();
            d.CultureInfo = CultureInfo.InvariantCulture;

            var dn = csv.Context.TypeConverterOptionsCache.GetOptions<double?>();
            dn.CultureInfo = CultureInfo.InvariantCulture;

            // Leaving this here just incase if we use another data set and it has weird null values
            dn.NullValues.AddRange(new[] { "NULL", "N/A" });

            var inn = csv.Context.TypeConverterOptionsCache.GetOptions<int?>();
            inn.NullValues.AddRange(new[] { "NULL", "N/A", "-" });
        }

        /// <summary>
        /// Creates and returns a preconfigured <see cref="CsvConfiguration"/> instance for parsing CSV files.
        /// </summary>
        /// <returns>A <see cref="CsvConfiguration"/> instance with predefined settings for CSV parsing.</returns>
        static CsvConfiguration GetCsvConfig()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                TrimOptions = TrimOptions.Trim,
                HeaderValidated = null,
                MissingFieldFound = null,
                BadDataFound = null,
            };

            return config;
        }

        /// <summary>
        /// Enqueue a page of stars into the current queue.
        /// </summary>
        /// <param name="queue"></param>
        /// <param name="buffer"></param>
        /// <param name="total"></param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <param name="cancellationToken"></param>
        static void EnqueuePage(BlockingQueue<PageResult<EquatorialStar>> queue,
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
