
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.Models;

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
            
            List<CoursesModel> courses;

            if (Search == null)
            {
                courses = _coursesService.GetAll();
            }
            else
            {
                courses = _coursesService.Search(Search);
            }



            return View(courses);
        }

        

        // GET: CoursesController/Details/5
        public ActionResult Details(int Id)
        {
            var course = _coursesService.GetAll().Where(x => x.Id == Id).FirstOrDefault();
            return View(course);

        }
        // POST: CoursesController/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(CoursesModel model)
        {
            try
            {
                var course = _coursesService.GetAll().Where(x => x.Id == model.Id).FirstOrDefault();
                if (course != null)
                {
                    course.Name = model.Name;
                    course.Duration = model.Duration;
                    course.Teacher = model.Teacher;
                    course.Description = model.Description;

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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
                _coursesService.Update(model); ;
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
