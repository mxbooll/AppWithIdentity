using Microsoft.AspNetCore.Identity;

namespace AppWithIdentity.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
