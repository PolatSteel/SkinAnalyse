using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
    public class DisplayingController : Controller
    {
       
        public IActionResult Display() 
        {
            return View();
        }

    }
}
