using SLM.Bussiness.DataServices.Interfaces;
using SLM.Bussiness.Models;

namespace SLM.Bussiness.DataServices
{
    public class CoursesService : ICourseService
    {
       private List<CoursesModel> courses = new List<CoursesModel>();

        public List<CoursesModel>GetAll()
        {
            courses.Add(new CoursesModel { Id = 1, Name = "DotNet Web Development", Duration = "1 hr", Description = "Description" });
            courses.Add(new CoursesModel { Id = 2, Name = "Graphic Designing", Duration = "1 hr", Description = "Description" });
            courses.Add(new CoursesModel { Id = 3, Name = "Software Quality Assurance", Duration = "1 hr", Description = "Description" });

            return courses;
        }

        public void Add (CoursesModel model)
        {
            courses.Add(model);
        }

        public void Delete(int Id)
        {
            var courseToDelete = courses.Where(x => x.Id == Id).FirstOrDefault();

            if (courseToDelete != null)
            {
                courses.Remove(courseToDelete);
                
            }
            
            
        }

        public void Details(int Id)
        {
            //List<CoursesModel> courses = new List<CoursesModel>();
            courses.Add(new CoursesModel { Id = 1, Name = "DotNet Web Development", Duration = "1 hr", Description = "Description" });
            courses.Add(new CoursesModel { Id = 2, Name = "Graphic Designing", Duration = "1 hr", Description = "Description" });
            courses.Add(new CoursesModel { Id = 3, Name = "Software Quality Assurance", Duration = "1 hr", Description = "Description" });

            //throw new NotImplementedException();
        }
    }
}