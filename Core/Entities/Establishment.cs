using Core.Entities.Identity;

namespace Core.Entities
{
    public class Establishment: BaseEntity
    {
        public string Name { get; set; }
        public IReadOnlyList<Phone> Phone { get; set; }
        public IReadOnlyList<Schedule> Schedule { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
    }
}