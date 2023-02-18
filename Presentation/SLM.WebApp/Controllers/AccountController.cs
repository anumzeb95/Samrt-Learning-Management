using Microsoft.AspNetCore.Mvc;
using SLM.Bussines.Interfaces;
using SLM.WebApp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using SLM.Bussiness.DataServices;
using SLM.Bussiness.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SLM.Data;
using SLM.Data.Models;
using SLM.Data.Migrations;

namespace SLM.WebApp.Controllers
{
	//[Authorize]
	public class AccountController : Controller
	{
        //private readonly ILogger<HomeController> _logger;
        //private readonly SLManagementDbContext _context;
        private readonly IUserService _userService;
       



        //dependency injection
        public AccountController(IUserService userService)

        {
            this._userService = userService; ;
            /*_userService = userService;*/
        }
        //public AccountController(SLManagementDbContext context)

        //{
        //    _context = context;
        //}

        public IActionResult Dashboard()
		{
			return View();
		}

        [HttpGet]
        public IActionResult Details(int Id)
        {
            //List<User> u = _userService.User.ToList();

            var user = _userService.GetProfile(Id);

            return View(user);

           
        }

        // POST: CoursesController/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(UserModel model)
        {
            try
            {
                var user = _userService.GetAll().Where(x => x.Id == model.Id).FirstOrDefault();
                if (user != null)
                {
                    user.Name = model.Name;
                    user.Email = model.Email;
                    user.Password = model.Password;
                    user.DOB = model.DOB;
                    user.Gender = model.Gender;
                    user.Designation = model.Designation;
                    user.Course = model.Course;
                    user.Address = model.Address;
                    user.Contact = model.Contact;
                }
                return RedirectToAction(nameof(Details));

            }
            catch
            {
                return View();
            }
        }


        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}