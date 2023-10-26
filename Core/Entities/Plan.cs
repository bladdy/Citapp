namespace Core.Entities.Identity
{
    public class Plan: BaseEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public IReadOnlyList<PlanItem> PlanItems { get; set; }
    }
}