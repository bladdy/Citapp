namespace Core.Entities.Identity
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public IReadOnlyList<UserRole> UserRoles { get; set; }
    }
}