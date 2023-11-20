using Core.Entities.Company;

namespace Core.Specifications
{
    public class PlansWithDesciprionsSpecification : BaseSpecification<Plan>
    {
        public PlansWithDesciprionsSpecification(): base ()
        {
            AddInclude(x=> x.Description);
        }
    }
}