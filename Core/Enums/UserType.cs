using System.Runtime.Serialization;

namespace Core.Enums
{
    public enum UserType
    {
        [EnumMember(Value ="Super User")]
        SuperUser,
        [EnumMember(Value ="Administrator")]
        Admin,
        [EnumMember(Value ="User")]
        User,
        [EnumMember(Value ="Client")]
        Client,
        [EnumMember(Value ="Profeccional")]
        Profeccional
    }
}