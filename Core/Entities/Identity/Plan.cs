namespace Core.Entities.Identity
{
    public class Plan: BaseEntity
    {
        
        public string Name { get; set; }
        public IReadOnlyList<Description> Description { get; set; }
        public decimal Price { get; set; }
        //public IReadOnlyList<Establishment> Establishments { get; set; }
    }

    public class Description : BaseEntity
    {
        public string Detail { get; set; }
    }
}