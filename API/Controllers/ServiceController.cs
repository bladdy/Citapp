using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Core.Specifications;
using API.Dtos;
using AutoMapper;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IGenericRepository<Service> _serviceRepo;
        private readonly IGenericRepository<Category> _categoryRepo;
        private readonly IMapper _mapper;

        public ServiceController( IGenericRepository<Service> ServiceRepo, IGenericRepository<Category> CategoryRepo, IMapper mapper)
        {
            _categoryRepo = CategoryRepo;
            _mapper = mapper;
            _serviceRepo = ServiceRepo;
        }
        [HttpGet("GetServices")]
        public  async Task<ActionResult<IReadOnlyList<Service>>> GetServices()
        {
            var spec = new ServicesWithCategoriesSpecification();
            var service = await _serviceRepo.ListAsync(spec);
            return  Ok(_mapper.Map<IReadOnlyList<Service>, IReadOnlyList<ServiceToReturnDto>>(service));
        }
        [HttpGet("GetServices/{id}")]
        public async Task<ActionResult<ServiceToReturnDto>> GetServices(int id)
        {
            var spec = new ServicesWithCategoriesSpecification(id);
            var service = await _serviceRepo.GetEntityWithSpec(spec);
            return _mapper.Map<Service, ServiceToReturnDto>(service);
        }
        //https://www.udemy.com/course/learn-to-build-an-e-commerce-app-with-net-core-and-angular/learn/lecture/18137196#overview
        [HttpGet("GetServicesByCategory/{id}")]
        public async Task<ActionResult<IReadOnlyList<Service>>> GetServicesByCategory(int id)
        {
            var spec = new ServicesWithCategoriesSpecification(id, string.Empty);
            var service = await _serviceRepo.ListAsync(spec);
            return  Ok(_mapper.Map<IReadOnlyList<Service>, IReadOnlyList<ServiceToReturnDto>>(service));
        }
        [HttpGet("GetCategories")]
        public  async Task<ActionResult<IReadOnlyList<CategoryToReturnDto>>> GetCategories()
        {
            var categories = await _categoryRepo.ListAllAsync();
            return  Ok(_mapper.Map<IReadOnlyList<Category>, IReadOnlyList<CategoryToReturnDto>>(categories));
        }
        [HttpGet("GetCategories/{id}")]
        public async Task<ActionResult<CategoryToReturnDto>> GetCategories(int id)
        {
            var category = await _categoryRepo.GetByIdAsync(id);
            return _mapper.Map<Category, CategoryToReturnDto>(category);
        }
    }

}
