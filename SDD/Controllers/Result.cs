using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
    public class Result : Controller
    {
        public IActionResult ResultPage()
        {
            return View();
        }
    }
}
