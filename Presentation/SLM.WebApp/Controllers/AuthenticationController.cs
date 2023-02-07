using Azure.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SLM.Bussines.Interfaces;
using SLM.WebApp.Models;
using System.Security.Claims;

namespace SLM.WebApp.Controllers
{
 
    public class AuthenticationController : Controller
    {
             
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserModel model)
        {
            //logic to compare user from database or any other user provider
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

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex) 
            {
                return View (model);
            }
            
        }
    }
}
