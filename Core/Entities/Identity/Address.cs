namespace Core.Entities.Identity
{
    public class Address
    {
        //Puedes ponerle que herede de person para completar los datos personales
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }         
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        /*public int PersonId { get; set; }
        public Person Person { get; set; }*/
    }
}