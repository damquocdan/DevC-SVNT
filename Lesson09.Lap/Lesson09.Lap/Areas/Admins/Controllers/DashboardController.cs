using Microsoft.AspNetCore.Mvc;

namespace Lesson09.Lap.Areas.Admins.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
