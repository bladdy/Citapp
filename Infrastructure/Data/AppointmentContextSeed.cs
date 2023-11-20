using System.IO;
using System.Text.Json;
using Core.Entities;
using Core.Entities.Identity;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class AppointmentContextSeed
    {
        public static async Task SeedAsync(AppointmentContext context)
        {
            try
            {
                if (!context.Plans.Any())
                {                    
                    var plansData = File.ReadAllText("../Infrastructure/Data/SeedData/plans.json");
                    var plans = JsonSerializer.Deserialize<List<Plan>>(plansData);

                    foreach (var item in plans)
                    {
                        context.Plans.Add(item);
                    }

                    await context.SaveChangesAsync();
                    
                }
                if (!context.Categories.Any())
                {                    
                    var categoriesData = File.ReadAllText("../Infrastructure/Data/SeedData/category.json");
                    var categories = JsonSerializer.Deserialize<List<Category>>(categoriesData);

                    foreach (var item in categories)
                    {
                        context.Categories.Add(item);
                    }

                    await context.SaveChangesAsync();
                    
                }
                if (!context.Services.Any())
                {                    
                    var serviceData = File.ReadAllText("../Infrastructure/Data/SeedData/service.json");
                    var services = JsonSerializer.Deserialize<List<Service>>(serviceData);

                    foreach (var item in services)
                    {
                        context.Services.Add(item);
                    }

                    await context.SaveChangesAsync();
                    
                }
            }
            catch (Exception ex)
            {
                //var logger = loggerFactory.CreateLogger<AppointmentContext>();
                //logger.LogError(ex.Message);
                var e = ex;
                throw;
            }
        }
    }
}