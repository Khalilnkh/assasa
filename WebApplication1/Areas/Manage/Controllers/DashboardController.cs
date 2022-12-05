using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Area.Controllers
{
    public class DashboardController : Controller
    {
        [Area("manage")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
