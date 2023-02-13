using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.Models;
using System.Security.Claims;

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


        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserModel model)
        {
            //here our logic is  to compare user from database or any other user provider
            try
            {
                //creating list of claims 
                var claims = new List<Claim>
                {
                new Claim (ClaimTypes.Email, model.Email),
                };

                //claims identity
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                //creating claims principal object to pass to the sign in method
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                //signing in
                await HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Dashboard", "Account");
            }
            catch (Exception ex)
            {
                return View(model);
            }

        }

        public async Task<IActionResult> Logout()
        {
            await this.HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
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
