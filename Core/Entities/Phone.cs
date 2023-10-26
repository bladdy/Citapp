namespace Core.Entities.Identity
{
    public class Phone: BaseEntity
    {
        public string Type { get; set; }
        public string NumberPhone { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}