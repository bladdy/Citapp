using System.Reflection;
using Core.Entities;
using Core.Entities.Company;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
        }
        //Company 
        public DbSet<EstablichmentAddress> EstablichmentAddresses { get; set; }
        public DbSet<EstablishmentService> EstablishmentServices { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        //Settings
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