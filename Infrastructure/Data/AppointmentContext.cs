using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Service> Services { get; set; }
    }
}