using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly AppointmentContext _context;

        public ServiceController( AppointmentContext context)
        {
            _context = context;
        }
         [HttpGet]
        public  async Task<ActionResult<List<Service>>> GetServices()
        {
            return await _context.Services.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetServices(int id)
        {
            return await _context.Services.FindAsync(id);
        }
    }

}
