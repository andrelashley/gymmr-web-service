using Microsoft.AspNetCore.Identity;

namespace Gymmr.Models
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
    }
}
