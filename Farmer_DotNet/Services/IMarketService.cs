using Farmer_DotNet.Model;

namespace Farmer_DotNet.Services
{
    public interface IMarketService
    {
        Task<IEnumerable<Market>> GetAllTodosAsync();
        Task<Market> GetTodoByIdAsync(int id);
        Task<IEnumerable<Market>> SearchTodosAsync(string keyword);
        Task AddTodoAsync(Market item);
        Task UpdateTodoAsync(Market item);
        Task DeleteTodoAsync(int id);
    }
}
