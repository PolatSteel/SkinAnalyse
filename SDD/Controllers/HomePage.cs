using BusinessLayer.Abstruct;
using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
    public class HomePage : Controller
    {
        private readonly ILoginService _loginService;

        public HomePage(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public IActionResult AnaSayfa(int UserId)
        {
            var values = _loginService.TGetAll();
            string UserName = _loginService.TGetUserNameById(UserId);
            ViewBag.UserName = UserName;
            TempData["UserName"] = UserName;
            return View(values);
        }

    }
}
