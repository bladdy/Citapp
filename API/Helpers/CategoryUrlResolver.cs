using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class CategoryUrlResolver: IValueResolver<Category, CategoryToReturnDto, string>
    {
        private readonly IConfiguration _config;
        
        public CategoryUrlResolver(IConfiguration config)
        {
            _config = config;
        }
//impelenta eso
        public string Resolve(Category source, CategoryToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.IconUrl))
            {
                return _config["ApiUrl"] + source.IconUrl;
            }
            return null;
        }
    }
}