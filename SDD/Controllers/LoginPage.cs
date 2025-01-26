using BusinessLayer.Abstruct;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SDD.Controllers
{
	public class LoginPage : Controller
	{
		private readonly ILoginService _loginService;
        private readonly IUserService _userService;

        public LoginPage(ILoginService loginService, IUserService userService)
		{
			this._loginService = loginService;
            _userService = userService;

        }
		[HttpGet]
		public IActionResult Login() 
		{
			var values = _userService.TGetAll();
			return View(values);
		}
        [HttpPost]
        public IActionResult Login(string NameOrEmail, string PassWord)
        { 
            // Veritabanından kullanıcıyı kontrol et
            var user = _userService.TGetAll().FirstOrDefault(u =>
                (u.userName == NameOrEmail || u.userEmail == NameOrEmail) &&
                u.userPassWord == PassWord); // Gerçek uygulamada şifreyi hashleyerek karşılaştırın

            if (user != null)
            {
                // Kullanıcı bulundu, oturum aç
                // Örneğin, authentication işlemleri yapılabilir
                return RedirectToAction("Home", "HomePage");
            }

            // Kullanıcı bulunamadı
            ViewBag.ErrorMessage = "Kullanıcı adı, e-posta veya şifre yanlış.";
            return View();
        }
    }
}
