using Farmer_DotNet.Model;

namespace Farmer_DotNet.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> SearchAsync(string keyword);
        Task AddAsync(Product item);
        Task UpdateAsync(Product item);
        Task DeleteAsync(int id);
    }
}
