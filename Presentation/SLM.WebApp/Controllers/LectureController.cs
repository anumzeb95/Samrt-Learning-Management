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
        private readonly object _hostingEnv;

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
        [HttpPost ("FileUpload")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(LectureModel model,List <IFormFile> files)
        {
            //"wwwroot", "file", 
            try
            {
                var size = files.Sum(f => f.Length);
            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), formFile.FileName); //we are using Temp file name just for the example. Add your own file path.
                    filePaths.Add(filePath);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            //return Ok(new { count = files.Count, size, filePaths });

            
                //todo: need to check if that is useful
                model.Course = null;
                _lectureService.Add(model);
                return RedirectToAction(nameof(Index), new { Id = model.CourseId, count = files.Count, size, filePaths });
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
