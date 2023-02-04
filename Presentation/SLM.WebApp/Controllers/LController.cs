using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SLM.Data.Models;
using System.Data;

namespace SLM.WebApp.Controllers
{
    public class LController : Controller
    {
        string conString = "Data Source=.;Initial Catalog =DemoTest; integrated security=true;";

        //GET: Files 
        public IActionResult Index(Lecture model)
        {
            List<Lecture> list = new List<Lecture>();
            DataTable DbSet = Lecture();
            foreach (DataRow dr in DbSet.Rows)
            {
                list.Add(new Lecture
                {

            Id = model.Id,
            LectureName  = model.LectureName,
            LectureDescription  = model.LectureDescription,
            LectureURL = model.LectureURL,
            CourseId = model.Id,

                });
            }
            model.FileList = list;
            return View(model);
        }
    }
}
