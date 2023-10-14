using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ServicesWithCategoriesSpecification: BaseSpecification<Service>
    {

        public ServicesWithCategoriesSpecification()
        {
            AddInclude(x => x.Category);
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