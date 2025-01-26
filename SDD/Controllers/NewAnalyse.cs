using BusinessLayer.Abstruct;
using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
    public class NewAnalyse : Controller
    {
        private readonly ILoginService _loginService;
        public NewAnalyse(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public IActionResult AddAnalyse(int UserId) 
        {
            string UserName = _loginService.TGetUserNameById(UserId);
            return View();
        }
    }
}
