using Microsoft.AspNetCore.Identity;

namespace BellBanking.Infraestructure.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public bool IsActive { get; set; }
    }
}
