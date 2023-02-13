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
        // GET: AccountController
        public ActionResult Dashboard()
        {
            return View();
        }

        // GET: AccountController/Details/5
        public ActionResult Profile()
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
