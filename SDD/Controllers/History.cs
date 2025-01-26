using Microsoft.AspNetCore.Mvc;

namespace SDD.Controllers
{
	public class History : Controller
	{
		public IActionResult HistoryPage()
		{
			return View();
		}
	}
}
