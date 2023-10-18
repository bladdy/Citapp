using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ServicesWithCategoriesSpecification: BaseSpecification<Service>
    {

        public ServicesWithCategoriesSpecification( ServiceSpecParams specParams ) 
            :base(x =>
                (!specParams.CategoryId.HasValue || x.CategoryId == specParams.CategoryId)
            )
        {
            AddInclude(x => x.Category);
            AddOrderBy(x => x.Name);
            ApplyPaging(specParams.PageSize * (specParams.PageIndex - 1), specParams.PageSize);
            if (!string.IsNullOrEmpty(specParams.Sort))
            {
                switch (specParams.Sort)
                {
                    case"priceAsc":
                        AddOrderBy(x => x.Price);    
                    break;
                    case"priceDesc":
                        AddOrderByDescending(x => x.Price);    
                    break;
                    default:
                        AddOrderBy(x => x.Name);
                    break;
                }
            }
        }

        public ServicesWithCategoriesSpecification(int id) : base(x =>x.Id ==id)
        {
            AddInclude(x => x.Category);
        }
        public ServicesWithCategoriesSpecification(int idCategory, string name) : base(x =>x.CategoryId ==idCategory )
        {
            AddInclude(x => x.Category);
        }
    }
}