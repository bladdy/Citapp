namespace Core.Entities.Identity
{
    public class PlanItem: BaseEntity
    {
        public string Description { get; set; }
        public Plan Plan { get; set; }
        public int PlanId { get; set; }
    }
}