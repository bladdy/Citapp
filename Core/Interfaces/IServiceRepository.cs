using System.Collections.Generic;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IServiceRepository
    {
        Task<Service> GetServiceByIdAsync(int id);
        Task<IReadOnlyList<Service>> GetServiceAsync();

    }
}