using BusinessLayer.Abstruct;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserService userService;

        public RegisterController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult RegisterPage() 
        {
            var values = userService.TGetAll();
            return View(values);
        }
        [HttpPost]
        public IActionResult RegisterPage(User user , string UserName , string PassWord , string Email , string Name) 
        {
            user.userName = UserName;
            user.userPassWord = PassWord;
            user.userEmail = Email;
            user.userFullName = Name;

            userService.TAdd(user);

            return RedirectToAction("login", "LoginPage");
        }
    }
}
