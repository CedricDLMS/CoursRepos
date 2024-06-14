using Microsoft.AspNetCore.Mvc;

namespace CrudMVC.Controllers
{
	public class PartialController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Create()
		{
			return PartialView("_PartialCreate");
		}
	}
}
