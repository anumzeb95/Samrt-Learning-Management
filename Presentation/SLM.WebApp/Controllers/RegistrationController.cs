using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.Models;

namespace SLM.WebApp.Controllers
{

	public class RegistrationController : Controller
	{
		private readonly IUserService _userService;
		
		public RegistrationController(IUserService userService)
		{
			_userService = userService;
		}



		// GET: RegistrationController
		public ActionResult Index()
		{
          
            return View();
		}

       
        // POST: RegistrationController/Create
        [HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(UserModel model)
		{

			try
			{
				_userService.Add(model);
				
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

	}
}
