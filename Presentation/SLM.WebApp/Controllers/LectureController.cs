using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SLM.Bussiness.Interfaces;
using SLM.Bussiness.Models;

namespace SLM.WebApp.Controllers
{
	//[Authorize]
	public class LectureController : Controller
	{
		private readonly ILectureService _lectureService;

		public LectureController(ILectureService lectureService)
		{
			_lectureService = lectureService;
		}



		// GET: LectureController

		[HttpGet]
		public ActionResult Index(LectureModel model)
		{
			
			var models = _lectureService.GetAll();
			return View(models);
		}

		[HttpPost]

		//public ActionResult Index(LectureModel model, IFormFile formFile)
        public ActionResult Index()
        {
			//List<LectureModel> lecture = new List<LectureModel>(); 
			//var LectureModel = new LectureModel();
			//_lectureService.Add(LectureModel);


			//List<LectureModel> lecture = new List<LectureModel>();

			//if (ModelState.IsValid)
			//{


			//	string fileName = formFile.FileName;
			//	try
			//	{
			//		fileName = Path.GetFileName(fileName);

			//		string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Lecture", fileName);

			//		var stream = new FileStream(uploadpath, FileMode.Create);

			//		formFile.CopyToAsync(stream);

			//		ViewBag.Message = "File uploaded successfully.";

			//	}

			//	catch

			//	{

			//		ViewBag.Message = "Error while uploading the files.";
			//		return View();
			//	}
			//	lecture = _lectureService.GetAll();
			//}

			//else
			//{
			//	return RedirectToAction(nameof(Index));
			//}


			//return View(lecture);
			return View(); 


			//return RedirectToAction(nameof(Index));            



			//var models = _lectureService.GetAll();
			//return View(models);
		}

        // GET: LectureController
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]


        // POST: LectureController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LectureModel model)
        {
            try
            {
                _lectureService.Add(model);
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
          var lectureModel = _lectureService.GetById(id);
            //var course = _lectureService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            return View(lectureModel);
        }

        // POST: lectureController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LectureModel model)
        {
            try
            {
                _lectureService.Update(model); ;
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
		
		

            try
            {
                _lectureService.Delete(Id);
                ViewBag.Message = "lecture delected successfully.";
                return RedirectToAction(nameof(Index));
            }

            catch

            {
                return View();
            }


        }




    }
}
