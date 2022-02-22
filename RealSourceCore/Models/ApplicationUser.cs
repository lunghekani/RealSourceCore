using Microsoft.AspNetCore.Identity;

namespace RealSourceCore.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
