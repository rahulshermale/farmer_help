using Farmer_DotNet.Model;

namespace Farmer_DotNet.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllTodosAsync();
        Task<Product> GetTodoByIdAsync(int id);
        Task<IEnumerable<Product>> SearchTodosAsync(string keyword);
        Task AddTodoAsync(Product item);
        Task UpdateTodoAsync(Product item);
        Task DeleteTodoAsync(int id);
    }
}
