
using Core.Entities.Identity;


namespace Core.Entities.Company
{
    public class Establishment: BaseEntity
    {
        public string Name { get; set; }
        public IReadOnlyList<Phone> Phone { get; set; } = new List<Phone>();
        public IReadOnlyList<Schedule> Schedule { get; set; } = new List<Schedule>();
        public IReadOnlyList<EstablishmentService> EstablishmentServices { get; set; } = new List<EstablishmentService>();
        public EstablichmentAddress EstablichmentAddresses { get; set; } = new EstablichmentAddress();
        public string PhoneNumber { get; set; }
        public int PlanID { get; set; }
        public Plan Plan { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}