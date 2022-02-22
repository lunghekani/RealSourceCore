using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealSourceCore.Models;

namespace RealSourceCore.Controllers
{
    public class AdministrationController : Controller
    { 
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = userManager.Users;
            return View(users);
        }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
        // Rest of the code
    }
}

