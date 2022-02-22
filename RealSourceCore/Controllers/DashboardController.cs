using Microsoft.AspNetCore.Mvc;

namespace RealSourceCore.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
