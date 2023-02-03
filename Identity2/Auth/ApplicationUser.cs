using Microsoft.AspNetCore.Identity;

namespace Identity2.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string? UserNamee { get; set; }
        public string? Passwordd { get; set; }
    }
}
