using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
    public class Contact : Controller
    {
        public IActionResult iletisim()
        {
            return View();
        }
    }
}
