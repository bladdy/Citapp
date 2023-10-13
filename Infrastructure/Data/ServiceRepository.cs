
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
            return await _context.Services
            .Include(c => c.Category)
            .FirstOrDefaultAsync(s => s.Id == id);
        }
        public async  Task<IReadOnlyList<Service>> GetServiceAsync()
        {
            return await _context.Services
            .Include(c=> c.Category).ToListAsync();
        }

        public async Task<IReadOnlyList<Service>> GetServicesByCategoryAsync(int id)
        { 
            return await _context.Services
            .Include(c=> c.Category)
            .Where( c => c.CategoryId == id).ToListAsync();
        }

        public async Task<Category>GetCategoriesByIdAsync (int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<IReadOnlyList<Category>>GetCategoriesAsync ()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}