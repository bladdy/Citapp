using System.Text.Json;
using Core.Entities;
using Core.Entities.Company;
using System.Linq;
using Infrastructure.Identity;

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
                if (!context.Establishments.Any())
                {                    
                    
                    var establichment = new Establishment(){
                        Name = "Papolo Peluqueria",
                        PhoneNumber= "789999999",
                        Plan = context.Plans.FirstOrDefault(),
                        Phone = new List<Phone>(){
                            new () {
                                Type = "Movil",
                                NumberPhone = "80965125411",
                            }
                        }
                        ,
                        Schedule = new List<Schedule>(){
                            new() {
                                TimeStart = new TimeSpan(8, 00, 00),
                                TimeEnd = new TimeSpan(17, 00, 00),
                                WeekDay = DayOfWeek.Monday                  
                            },
                            new() {
                                TimeStart = new TimeSpan(8, 00, 00),
                                TimeEnd = new TimeSpan(17, 00, 00),
                                WeekDay = DayOfWeek.Tuesday                  
                            },
                            new() {
                                TimeStart = new TimeSpan(8, 00, 00),
                                TimeEnd = new TimeSpan(17, 00, 00),
                                WeekDay = DayOfWeek.Wednesday                  
                            },
                            new() {
                                TimeStart = new TimeSpan(8, 00, 00),
                                TimeEnd = new TimeSpan(17, 00, 00),
                                WeekDay = DayOfWeek.Thursday                  
                            },
                            new() {
                                TimeStart = new TimeSpan(8, 00, 00),
                                TimeEnd = new TimeSpan(17, 00, 00),
                                WeekDay = DayOfWeek.Friday                  
                            },
                            new() {
                                TimeStart = new TimeSpan(8, 00, 00),
                                TimeEnd = new TimeSpan(13, 00, 00),
                                WeekDay = DayOfWeek.Saturday                  
                            },
                            new() {
                                TimeStart = new TimeSpan(8, 00, 00),
                                TimeEnd = new TimeSpan(13, 00, 00),
                                WeekDay = DayOfWeek.Sunday                  
                            }
                        },
                        EstablichmentAddresses = new EstablichmentAddress(),
                        EstablishmentServices = new List<EstablishmentService>()
                        {
                            new() {
                                Service = context.Services.FirstOrDefault(),
                            },
                            new() {
                                Service = (Service)context.Services.First(x=> x.Id ==2)
                            },
                            new() {
                                Service = (Service)context.Services.First(x=> x.Id ==3)
                            }

                        },
                        Category = context.Categories.FirstOrDefault()
                    };
                    context.Establishments.Add(establichment);

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