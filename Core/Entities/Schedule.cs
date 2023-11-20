using Core.Entities.Identity;

namespace Core.Entities
{
    public class Schedule: BaseEntity
    {
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public DayOfWeek WeekDay { get; set; }
        public int WeekDayId { get; set; }
        public Establishment Establishment { get; set; }
        public int EstablishmentId { get; set; }
        /*public Professional Professional { get; set; } 
        public int ProfessionalId { get; set; }  */
        
    }
}