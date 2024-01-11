using Core.Entities.Company;
using Core.Enums;

namespace Core.Entities
{
    public class Appointment: BaseEntity
    {
        public string User { get; set; }
        public string MyProperty { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificatedDate { get; set; }
        public string Note { get; set; }
        public Establishment Establishment { get; set; }
        public int EstablishmentId { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }
        public AppointmentStatus Status { get; set; }
    }
}