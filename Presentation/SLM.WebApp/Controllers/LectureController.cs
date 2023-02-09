using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SLM.Bussiness.Interfaces;
using SLM.Bussiness.Models;

namespace SLM.WebApp.Controllers
{
	[Authorize]
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

			return View();
		}

		[HttpPost]

		public ActionResult Index(LectureModel model, IFormFile formFile)

		{
			//List<LectureModel> lecture = new List<LectureModel>(); 
			//var LectureModel = new LectureModel();
			//_lectureService.Add(LectureModel);


			List<LectureModel> lecture = new List<LectureModel>();

			if (ModelState.IsValid)
			{


				string fileName = formFile.FileName;
				try
				{
					fileName = Path.GetFileName(fileName);

					string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Lecture", fileName);

					var stream = new FileStream(uploadpath, FileMode.Create);

					formFile.CopyToAsync(stream);

					ViewBag.Message = "File uploaded successfully.";

				}

				catch

				{

					ViewBag.Message = "Error while uploading the files.";
					return View();
				}
				lecture = _lectureService.GetAll();
			}

			else
			{
				return RedirectToAction(nameof(Index));
			}


			return View(lecture);
			//return View(lecture); 


			//return RedirectToAction(nameof(Index));            



			//var models = _lectureService.GetAll();
			//return View(models);
		}

		// GET: CoursesController/Delete/5
		public ActionResult Delete(int Id)
		{
			_lectureService.Delete(Id);

			return RedirectToAction(nameof(Index));


		}

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




	}
}
