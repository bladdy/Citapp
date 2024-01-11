using System.Runtime.Serialization;

namespace Core.Enums
{
    public enum AppointmentStatus
    {
        [EnumMember(Value ="Pendient")]
        Pendient,
        [EnumMember(Value ="Confirmed")]
        Confirmed,
        [EnumMember(Value ="Completed")]
        Completed,
        [EnumMember(Value ="Cancelled")]
        Cancelled
    }
}