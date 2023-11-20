using Core.Entities.Company;

namespace Core.Entities
{
    public class Phone: BaseEntity
    {
        public string Type { get; set; }
        public string NumberPhone { get; set; }
        public Establishment Establishment { get; set; } 
        public int EstablishmentId { get; set; }
   }
}