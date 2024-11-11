using Microsoft.AspNetCore.Mvc;

namespace Lesson01.mvc.Controllers
{
    public class DomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
