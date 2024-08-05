using Farmer_DotNet.Model;

namespace Farmer_DotNet.Repositories
{
    public interface IMarketRepository
    {
        Task<IEnumerable<Market>> GetAllAsync();
        Task<Market> GetByIdAsync(int id);
        Task<IEnumerable<Market>> SearchAsync(string keyword);
        Task AddAsync(Market item);
        Task UpdateAsync(Market item);
        Task DeleteAsync(int id);
    }
}
