using Core.Entities;

namespace Core.Interfaces
{
    public interface IServiceRepository
    {
        Task<Service> GetServiceByIdAsync(int id);
        Task<IReadOnlyList<Service>> GetServiceAsync();
        Task<IReadOnlyList<Service>> GetServicesByCategoryAsync(int id);
        Task<Category> GetCategoriesByIdAsync (int id);
        Task<IReadOnlyList<Category>> GetCategoriesAsync();
    }
}
