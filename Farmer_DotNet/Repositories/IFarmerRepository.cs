using Farmer_DotNet.Model;

namespace Farmer_DotNet.Repositories
{
    public interface IFarmerRepository
    {
        Task<IEnumerable<Farmer>> GetAllAsync();
        Task<Farmer> GetByIdAsync(int id);
        Task<IEnumerable<Farmer>> SearchAsync(string keyword);
        Task AddAsync(Farmer item);
        Task UpdateAsync(Farmer item);
        Task DeleteAsync(int id);
    }
}
