using Microsoft.AspNetCore.Identity;

namespace AuthWithIdentity.Models
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; } // Additional property
    }
}
