namespace Core.Entities.Identity
{
    public class Establishment: BaseEntity
    {
        public string Name { get; set; }
        public IReadOnlyList<Phone> Phone { get; set; }
        public IReadOnlyList<Schedule> Schedule { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public int PlanID { get; set; }
        public Plan Plan { get; set; }
        //public IReadOnlyList<AppUser> AppUsers { get; set; }
    }
}