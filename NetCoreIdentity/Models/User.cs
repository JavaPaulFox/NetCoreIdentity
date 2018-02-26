using Microsoft.AspNetCore.Identity;

namespace NetCoreIdentity.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
