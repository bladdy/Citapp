
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly AppointmentContext _context;

        public ServiceRepository(AppointmentContext context)
        {
            _context = context;
        }
        public async Task<Service> GetServiceByIdAsync (int id)
        {
            return await _context.Services.FindAsync(id);
        }
        public async  Task<IReadOnlyList<Service>> GetServiceAsync()
        {
            return await _context.Services.ToListAsync();
        }
    }

}