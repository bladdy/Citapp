using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _repository;

        public ServiceController( IServiceRepository repository)
        {
            _repository = repository;
        }
         [HttpGet("GetServices")]
        public  async Task<ActionResult<List<Service>>> GetServices()
        {
            var service = await _repository.GetServiceAsync();
            return  Ok(service);
        }
        [HttpGet("GetServices/{id}")]
        public async Task<ActionResult<Service>> GetServices(int id)
        {
            return  await _repository.GetServiceByIdAsync(id);
        }
        [HttpGet("GetServicesByCategory/{id}")]
        public async Task<ActionResult<List<Service>>> GetServicesByCategory(int id)
        {
            List<Service> services = (List<Service>)await _repository.GetServicesByCategoryAsync(id);
            return services;
        }
        [HttpGet("GetCategories")]
        public  async Task<ActionResult<List<Category>>> GetCategories()
        {
            var categories = await _repository.GetCategoriesAsync();
            return  Ok(categories);
        }
        [HttpGet("GetCategories/{id}")]
        public async Task<ActionResult<Category>> GetCategories(int id)
        {
            return  await _repository.GetCategoriesByIdAsync(id);
        }
    }

}
