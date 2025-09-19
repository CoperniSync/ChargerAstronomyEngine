

using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Contracts.Repositories;
using ChargerAstronomyShared.Contracts.Streaming;
using ChargerAstronomyShared.Domain.Equatorial;
using System.Threading;
using System.Threading.Tasks;


namespace ChargerAstronomyEngine.Data
{

    public sealed class CsvStarRepository : IStarRepository
    {
        public Task<PageResult<EquatorialStar>> GetAllAsync(PageRequest page)
        {
            throw new System.NotImplementedException();
        }

        public Task<EquatorialStar> GetStarByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task ProducePagesAsync(IInitializationQueue<PageResult<EquatorialStar>> queue, PageRequest firstPage, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<PageResult<EquatorialStar>> QueryBySkyRegionAsync(SkyRegion skyRegion, PageRequest page)
        {
            throw new System.NotImplementedException();
        }
    }
}
