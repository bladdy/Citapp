using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Core.Specifications;
using API.Dtos;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IGenericRepository<Service> _serviceRepo;
        private readonly IGenericRepository<Category> _categoryRepo;

        public ServiceController( IGenericRepository<Service> ServiceRepo, IGenericRepository<Category> CategoryRepo)
        {
            _categoryRepo = CategoryRepo;
            _serviceRepo = ServiceRepo;
        }
        [HttpGet("GetServices")]
        public  async Task<ActionResult<List<Service>>> GetServices()
        {
            var spec = new ServicesWithCategoriesSpecification();
            var service = await _serviceRepo.ListAsync(spec);
            return  Ok(service);
        }
        [HttpGet("GetServices/{id}")]
        public async Task<ActionResult<ServiceToReturnDto>> GetServices(int id)
        {
            var spec = new ServicesWithCategoriesSpecification(id);
            var service = await _serviceRepo.GetEntityWithSpec(spec);
            return new ServiceToReturnDto
            {
                Id = service.Id,
                Name = service.Name,
                Description = service.Description,
                Price = service.Price,
                PictureUrl = service.PictureUrl,
                Category = service.Category.Name
                

            };
        }
        //https://www.udemy.com/course/learn-to-build-an-e-commerce-app-with-net-core-and-angular/learn/lecture/18137196#overview
        [HttpGet("GetServicesByCategory/{id}")]
        public async Task<ActionResult<List<Service>>> GetServicesByCategory(int id)
        {
            var spec = new ServicesWithCategoriesSpecification(id, string.Empty);
            var services = await _serviceRepo.ListAsync(spec);
            return Ok(services);
        }
        [HttpGet("GetCategories")]
        public  async Task<ActionResult<List<Category>>> GetCategories()
        {
            var categories = await _categoryRepo.ListAllAsync();
            return  Ok(categories);
        }
        [HttpGet("GetCategories/{id}")]
        public async Task<ActionResult<Category>> GetCategories(int id)
        {
            return  await _categoryRepo.GetByIdAsync(id);
        }
    }

}
