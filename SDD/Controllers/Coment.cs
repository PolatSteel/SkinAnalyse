using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
    public class Coment : Controller
    {
        public IActionResult ComentPage()
        {
            return View();
        }
    }
}
