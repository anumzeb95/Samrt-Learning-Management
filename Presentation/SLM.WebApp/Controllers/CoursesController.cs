using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SLM.Bussiness.DataServices;
using SLM.Bussiness.DataServices.Interfaces;
using SLM.Bussiness.Models;
using System.Drawing.Text;

namespace SLM.WebApp.Controllers
{
    public class CoursesController : Controller
    {

        private readonly ICourseService _coursesService;

        //dependency injection
        public CoursesController(ICourseService coursesService)
        {
            _coursesService = coursesService;
        }

        // GET: CoursesController
        public ActionResult Index(string? Search)
        {

            //var courses = new List<CoursesModel>();
            //courses.Add(new CoursesModel { Id = 1, Name = "DotNet Web Development" });
            //courses.Add(new CoursesModel { Id = 2, Name = "Graphic Designing" });
            //courses.Add(new CoursesModel { Id = 3, Name = "Software Quality Assurance" });
            List<CoursesModel> courses = null;
            if(Search == null)
            {
              courses = _coursesService.GetAll();
            }
            else
            {
                courses = _coursesService.GetAll().Where(x => x.Name.ToLower().Contains(Search.Trim().ToLower())).ToList();
            }

            return View(courses);
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CoursesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CoursesModel model)
        {
            try
            {
                _coursesService.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
           var course = _coursesService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            return View(course);
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CoursesModel model)
        {
            try
            {
                var course = _coursesService.GetAll().Where(x => x.Id == model.Id).FirstOrDefault();
                if (course != null)
                {
                    course.Name = model.Name;
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int Id)
        {
            _coursesService.Delete(Id);
            
            return RedirectToAction(nameof(Index));

            
        }

      
    }
}
