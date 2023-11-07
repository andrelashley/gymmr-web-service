using Microsoft.AspNetCore.Mvc;

namespace Gymmr.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
