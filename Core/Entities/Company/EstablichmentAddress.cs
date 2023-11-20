

namespace Core.Entities.Company
{
    public class EstablichmentAddress
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }    
        public bool IsMain { get; set; }   
        public int EstablishmentId { get; set; }
        public Establishment Establishment { get; set; } 
    }
}