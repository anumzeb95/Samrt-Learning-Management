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
        private readonly SLManagementDbContext _context;
        private readonly IUserService _userService;
        
        public AccountController(IUserService userService)

        {
            _userService = userService;
        }
        //public AccountController(SLManagementDbContext context)

        //{
        //    _context = context;
        //}

        public IActionResult Dashboard()
		{
			return View();
		}

       
        public IActionResult Details(UserModel model)
        {
            return View(model);

            //try
            //{ , int Id
            //    var user = _userService.GetAll().Where(x => x.Id == model.Id).FirstOrDefault();
            //    if (user != null)
            //    {
            //        user.Name = model.Name;
            //        user.Email = model.Email;
            //        user.Password = model.Password;
            //        user.DOB = model.DOB;
            //        user.Gender = model.Gender;
            //        user.Designation = model.Designation;
            //        user.Course = model.Course;
            //        user.Address = model.Address;
            //        user.Contact = model.Contact;

            //    }
            //    return View(Details);
            //}
            //catch
            //{
            //    return RedirectToAction(nameof(Details));
            //}

        }





        //var user = _userService.GetAll().Where(x => x.Id == Id).FirstOrDefault();
        //return View(user);
        //User = User.Identity.
        //return View("Profile");


        //if (ModelState.IsValid==true)
        //{
        //    _userService.Add(model);
        //    var user= _userService.GetAll().Where(x => x.Id == model.Id).FirstOrDefault();
        //    if (user != null)
        //    {
        //        user.Name = model.Name;
        //        user.Email = model.Email;
        //        user.Password = model.Password;
        //        user.DOB = model.DOB;
        //        user.Gender = model.Gender;
        //        user.Designation = model.Designation;
        //        user.Course = model.Course;
        //        user.Address = model.Address;
        //        user.Contact = model.Contact;

        //    }
        //    else return View();

        //}
        //return RedirectToAction(nameof(Details));

        //return View();

        // POST: PrfileController/Details/5

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Details(UserModel model)
        //{
        //    try
        //    {
        //        var user = _userService.GetAll().Where(x => x.Id == model.Id).FirstOrDefault();
        //        if (user != null)
        //        {
        //            user.Name = model.Name;
        //            user.Email = model.Email;
        //            user.Password = model.Password;
        //            user.DOB = model.DOB;
        //            user.Gender = model.Gender;
        //            user.Designation = model.Designation;
        //            user.Course = model.Course;
        //            user.Address = model.Address;
        //            user.Contact = model.Contact;

        //        }
        //        return RedirectToAction(nameof(Details));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


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