using Core.Entities;
using Core.Entities.Company;


namespace Core.Specifications
{
    public class EstablishmentsWithFiltersForCountSpecification: BaseSpecification<Establishment>
    {
        public EstablishmentsWithFiltersForCountSpecification(EstablishmentsSpecParams specParams) :base(x =>
                (string.IsNullOrEmpty(specParams.Search) || x.Name.ToLower().Contains(specParams.Search)) &&
                (!specParams.CategoryId.HasValue || x.CategoryID == specParams.CategoryId)
            )
        {
            
        }
    }
}