using Core.Entities;

namespace Core.Specifications
{
    public class ServicesWithFiltersForCountSpecification : BaseSpecification<Service>
    {
        public ServicesWithFiltersForCountSpecification(ServiceSpecParams specParams) :base(x =>
                (!specParams.CategoryId.HasValue || x.CategoryId == specParams.CategoryId)
            )
        {
            
        }
        
    }
}