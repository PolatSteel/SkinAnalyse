using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
