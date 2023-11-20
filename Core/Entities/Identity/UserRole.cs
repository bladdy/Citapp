namespace Core.Entities.Identity
{
    public class UserRole
    {
        public int UserID { get; set; }
        public AppUser AppUser { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}