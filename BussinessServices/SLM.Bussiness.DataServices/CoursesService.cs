using SLM.Bussiness.DataServices.Interfaces;
using SLM.Bussiness.Models;

namespace SLM.Bussiness.DataServices
{
    public class CoursesService : ICourseService
    {
       private List<CoursesModel> courses = new List<CoursesModel>();

        public List<CoursesModel>GetAll()
        {
            courses.Add(new CoursesModel { Id = 1, Name = "DotNet Web Development" });
            courses.Add(new CoursesModel { Id = 2, Name = "Graphic Designing" });
            courses.Add(new CoursesModel { Id = 3, Name = "Software Quality Assurance" });

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
            throw new NotImplementedException();
        }
    }
}