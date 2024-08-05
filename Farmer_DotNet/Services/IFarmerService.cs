using Farmer_DotNet.Model;

namespace Farmer_DotNet.Services
{
    public interface IFarmerService
    {
        Task<IEnumerable<Farmer>> GetAllTodosAsync();
        Task<Farmer> GetTodoByIdAsync(int id);
        Task<IEnumerable<Farmer>> SearchTodosAsync(string keyword);
        Task AddTodoAsync(Farmer item);
        Task UpdateTodoAsync(Farmer item);
        Task DeleteTodoAsync(int id);
    }
}
