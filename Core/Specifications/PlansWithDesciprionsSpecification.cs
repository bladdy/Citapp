using Core.Entities.Identity;

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