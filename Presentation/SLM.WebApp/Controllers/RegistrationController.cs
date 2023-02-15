using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
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
                //new Claim (ClaimTypes.Password, model.Password),
                };

                //claims identity
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                //creating claims principal object to pass to the sign in method
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                //signing in
                await HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Dashboard", "Account");
            }
            catch (Exception exp)
            {
                return View(model);
            }

        }





        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await this.HttpContext.SignOutAsync();
            //return RedirectToAction("Index", "Home");
            return RedirectToAction(nameof(Login));
        }






      
    }
}
