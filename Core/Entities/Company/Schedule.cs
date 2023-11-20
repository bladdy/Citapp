


namespace Core.Entities.Company
{
    public class Schedule: BaseEntity
    {
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public DayOfWeek WeekDay { get; set; }
        public Establishment  Establishment{ get; set; }
        public int EstablishmentId { get; set; }
        
    }
}