using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Crear mapper por cada Dto que se quiera
            CreateMap<Service, ServiceToReturnDto>()
            .ForMember(d => d.Category, o=> o.MapFrom(s =>s.Category.Name ))
            .ForMember(d => d.PictureUrl, o=> o.MapFrom<ServiceUrlResolver>());
            CreateMap<Category, CategoryToReturnDto>()
            .ForMember(d => d.IconUrl, o=> o.MapFrom<CategoryUrlResolver>());
        }
    }
}