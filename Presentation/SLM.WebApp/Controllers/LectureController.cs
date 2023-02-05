using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SLM.Bussiness.Interfaces;
using System.IO;
using SLM.Data.Models;
using System.Data;

namespace SLM.WebApp.Controllers
{
    public class LectureController : Controller
    {
        private readonly ILectureService _lectureService;

        public LectureController (ILectureService lectureService)
        {
            _lectureService = lectureService;
        }



        // GET: LectureController
        [HttpGet]
        public ActionResult Index()
        {
            //var LectureModel = new LectureModel { LectureName = "DOT1" };
            //_lectureService.Add(LectureModel);


            //List<Lecture> list = new List<Lecture>();
            //DataTable DbSet = Lecture();
            //foreach (DataRow dr in DbSet.Rows)
            //{
            //    list.Add(new Lecture
            //    {

            //        Id = model.Id,
            //        LectureName = model.LectureName,
            //        LectureDescription = model.LectureDescription,
            //        LectureURL = model.LectureURL,
            //        CourseId = model.Id,

            //    });
            //}
            //model.FileList = list;
            //return View(model);

            var models = _lectureService.GetAll();
            return View();
        }

        [HttpPost]

        public ActionResult Index(IFormFile formFile)

        {

            try

            {

                string fileName = formFile.FileName;

                fileName = Path.GetFileName(fileName);

                string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Lecture", fileName);

                var stream = new FileStream(uploadpath, FileMode.Create);

                formFile.CopyToAsync(stream);

                ViewBag.Message = "File uploaded successfully.";

            }

            catch

            {

                ViewBag.Message = "Error while uploading the files.";

            }

            return View();

        }








        // GET: LectureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LectureController/Create
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

        // GET: LectureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LectureController/Edit/5
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

        // GET: LectureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LectureController/Delete/5
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
