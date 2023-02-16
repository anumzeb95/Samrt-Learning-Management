using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using SLM.Bussiness.Interfaces;
using SLM.Bussiness.Models;


namespace SLM.WebApp.Controllers
{
    [Authorize]
    public class LectureController : Controller
	{
        private readonly ILectureService _lectureService;

        

        public LectureController(ILectureService LectureService)
        {
            _lectureService = LectureService;
        }


        // GET: ProductController
        public ActionResult Index(int CourseId)
        {
            ViewBag.CourseId = CourseId;
           
            var lecture = _lectureService.LectureForCourse(CourseId);
            return View(lecture);
        }

        // GET: ProductController/Create
        public ActionResult Create(int? CourseId)
        {
            ViewBag.CourseId = CourseId;
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        //[HttpPost ("FileUpload")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(LectureModel model, IFormFile file)
        {
            //.Trim('"')
            try
            {
                if (ModelState.IsValid)
                {
                    var filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString();
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "file", file.FileName);
                    using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    model.LectureURL = filename;
                    //todo: need to check if that is useful
                   // model.Course = null;
                    _lectureService.Add(model);
                    return RedirectToAction(nameof(Index), new { CourseId = model.CourseId });

                }
                else
                    return View();

            }
            catch
            {
                return View();
            }
           
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id, int CourseId)
        {
            var lecture = _lectureService.GetAll().Where(x => x.Id == id).FirstOrDefault();

            return View(lecture);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LectureModel model)
        {
            try
            {
                model.Course = null;
                _lectureService.Update(model);
                return RedirectToAction(nameof(Index), new { storeId = model.CourseId });
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id, int CourseId)
        {
            _lectureService.Delete(id);
            return RedirectToAction(nameof(Index), new { CourseId });
        }

        //public ActionResult Download(int id, int CourseId)
        //{
        //    _lectureService.Download(id);
        //    return RedirectToAction(nameof(Index), new { CourseId });
        //}


    }
}
