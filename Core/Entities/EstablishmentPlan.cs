namespace Core.Entities.Identity
{
    public class EstablishmentPlan: BaseEntity
    {
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        public int EstablishmentId { get; set; }
        public Establishment Establishment { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime LastPaymentDdate { get; set; }
        public IReadOnlyList<Service> Services { get; set; }
    }
}