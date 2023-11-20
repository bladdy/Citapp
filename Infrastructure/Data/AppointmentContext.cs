using System.Reflection;
using Core.Entities;
using Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
             if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType == typeof(decimal));

                    foreach (var property in properties)
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name).HasConversion<double>();
                    }
                }
            }
        }
    }
}