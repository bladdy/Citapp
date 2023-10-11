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
         [HttpGet]
        public  async Task<ActionResult<List<Service>>> GetServices()
        {
            var service = await _repository.GetServiceAsync();
            return  Ok(service);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetServices(int id)
        {
            return  await _repository.GetServiceByIdAsync(id);
        }
    }

}
