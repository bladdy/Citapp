using Core.Entities.Identity;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class SettingsController: BaseApiController
    {
        private readonly IGenericRepository<Plan> _planRepo;
        public SettingsController(IGenericRepository<Plan> PlanRepo)
        {
            _planRepo = PlanRepo;
        }
        [HttpGet("GetPlans")]
        public async Task<ActionResult<IReadOnlyList<Plan>>> GetPlansAsync()
        { 
            var spec = new PlansWithDesciprionsSpecification();
            var plan = await _planRepo.ListAsync(spec);
            return Ok(plan);
        }
    }
}