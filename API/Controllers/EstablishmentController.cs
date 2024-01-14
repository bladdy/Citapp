using API.Dtos;
using API.Errors;
using API.Helpers;
using AutoMapper;
using Core.Entities.Company;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstablishmentController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Establishment> _establishmentRepo;
        public EstablishmentController(IGenericRepository<Establishment> Establishment, IMapper mapper)
        {
            _establishmentRepo = Establishment;
            _mapper = mapper;
        }

        [HttpGet("GetEstablishments")]
        public async Task<ActionResult<Pagination<EstablishmentsDto>>> GetEstablishmentAsync([FromQuery] EstablishmentsSpecParams establishmentsSpecParams)
        {
            var spec = new EstablismentWithSpecification(establishmentsSpecParams);
            var establishment = await _establishmentRepo.ListAsync(spec);

            var countSpec = new EstablismentWithSpecification(establishmentsSpecParams);
            var totalItems = await _establishmentRepo.CountAsync(countSpec);

            var data = _mapper.Map<IReadOnlyList<Establishment>, IReadOnlyList<EstablishmentsDto>>(establishment);
            return Ok(new Pagination<EstablishmentsDto>(establishmentsSpecParams.PageIndex, establishmentsSpecParams.PageSize, totalItems, data));
        }
        [HttpGet("GetEstablishments/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EstablishmentsDto>> GetEstablishmentAsync(int id)
        {
            var spec = new EstablismentWithSpecification(id);
            var establishment = await _establishmentRepo.GetEntityWithSpec(spec);
            if (establishment == null) return NotFound(new ApiResponse(404));
            return _mapper.Map<Establishment, EstablishmentsDto>(establishment);
        }
    }
}