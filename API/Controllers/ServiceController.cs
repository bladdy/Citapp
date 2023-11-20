
namespace API.Controllers
{
    using Core.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Core.Interfaces;
    using Core.Specifications;
    using API.Dtos;
    using AutoMapper;
    using API.Errors;
    using API.Helpers;
    public class ServiceController : BaseApiController
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
        public  async Task<ActionResult<Pagination<ServiceToReturnDto>>> GetServices( [FromQuery]ServiceSpecParams serviceParams )
        {
            var spec = new ServicesWithCategoriesSpecification(serviceParams);
            var service = await _serviceRepo.ListAsync(spec);

            var countSpec = new ServicesWithFiltersForCountSpecification(serviceParams);
            var totalItems = await _serviceRepo.CountAsync(countSpec);

            var data = _mapper.Map<IReadOnlyList<Service>, IReadOnlyList<ServiceToReturnDto>>(service);
            return Ok( new Pagination<ServiceToReturnDto>(serviceParams.PageIndex, serviceParams.PageSize, totalItems, data));
        }
        [HttpGet("GetServices/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ServiceToReturnDto>> GetServices(int id)
        {
            var spec = new ServicesWithCategoriesSpecification(id);
            var service = await _serviceRepo.GetEntityWithSpec(spec);
            if(service == null) return NotFound(new ApiResponse(404));
            return _mapper.Map<Service, ServiceToReturnDto>(service);
        }
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
