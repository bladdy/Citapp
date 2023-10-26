
namespace Core.Entities.Identity
{
    public class Person : BaseEntity
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }
        public IReadOnlyList<Phone> Phone { get; set; }
        

    }
}