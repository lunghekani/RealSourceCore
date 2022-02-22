using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealSourceCore.Utility
{
    public class Helper
    {
        public static string Admin = "Admin";
        public static string Customer = "Customer";
        public static string Writer = "Writer";

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                //new SelectListItem { Text = Helper.Admin, Value = Helper.Admin },
                new SelectListItem { Text = Helper.Customer, Value = Helper.Customer },
                new SelectListItem { Text = Helper.Writer, Value = Helper.Writer }
            };
        }

        //public async Task MyCustomSignOut(string redirectUri)
        //{
        //    // inject the HttpContextAccessor to get "context"
        //    await context.SignOutAsync("Cookies");
        //    var prop = new AuthenticationProperties()
        //    {
        //        RedirectUri = redirectUri
        //    };
        //    // after signout this will redirect to your provided target
        //    await context.SignOutAsync("oidc", prop);
        //}
    }
}
