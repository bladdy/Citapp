using Core.Entities.Company;
using Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
    public class AppUser: IdentityUser
    {
        public string DisplayName { get; set; }
        //hay que quitarle el addres al usuario
        public Address Address { get; set; }
        public UserType UserType { get; set; }
        //quitarle el usertype por un listado de roles
        //public IReadOnlyList<UserRole> UserRoles { get; set; }
        //agregarle la compañia al usuario
        public int EstablishmentId { get; set; }
    }
}