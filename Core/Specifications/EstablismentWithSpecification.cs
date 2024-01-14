using Core.Entities;
using Core.Entities.Company;

namespace Core.Specifications
{
    public class EstablismentWithSpecification : BaseSpecification<Establishment>
    {
        public EstablismentWithSpecification(EstablishmentsSpecParams specParams):base(x =>
                (string.IsNullOrEmpty(specParams.Search) || x.Name.ToLower().Contains(specParams.Search)) &&
                (!specParams.CategoryId.HasValue || x.CategoryID == specParams.CategoryId)
            )
        {
            AddInclude(x=> x.Plan);
            AddInclude(x=>x.Category);
            AddInclude(x=> x.Phone);
            AddInclude(x=> x.EstablishmentServices);
            AddInclude(x=> x.EstablichmentAddresses);
            AddInclude(x=> x.Schedule);
            AddOrderBy(x => x.Name);
        }
        public EstablismentWithSpecification(int id) : base(x =>x.Id ==id)
        {
            AddInclude(x=>x.Category);
            AddInclude(x=> x.Phone);
            AddInclude(x=> x.EstablishmentServices);
            AddInclude(x=> x.EstablichmentAddresses);
            AddInclude(x=> x.Schedule);
            AddOrderBy(x => x.Name);
        }
    }
}