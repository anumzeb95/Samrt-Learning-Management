
using SLM.Bussiness.DataServices.Interfaces;
using SLM.Bussiness.Models;
using SLM.Data;
using System.Security.Cryptography.X509Certificates;

namespace SLM.Bussiness.DataServices
{
    public class CoursesService : ICourseService
    {
        private readonly SLManagementDbContext _dbContext;
         public CoursesService(SLManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<CoursesModel> GetAll()
        {
            var allCourses = _dbContext.Courses.ToList();
            var CoursesModel = allCourses.Select(x => new CoursesModel
            { 
                Id = x.Id,
                Name = x.Name,
                Duration = x.Duration,
                Teacher = x.Teacher,
                Description = x.Description
            }).ToList();   

            return CoursesModel;
        }


        public List<CoursesModel> Search(string searchTerm)
        {
            searchTerm = searchTerm.Trim().ToLower();
            var allCourses = _dbContext.Courses.Where(x => x.Name.ToLower().Contains(searchTerm) ||
            x.Teacher.ToLower().Contains(searchTerm)).ToList();
            var CoursesModel = allCourses.Select(x => new CoursesModel
            {
                Id = x.Id,
                Name = x.Name,
                Duration = x.Duration,
                Teacher = x.Teacher,
                Description = x.Description
            }).ToList();

            return CoursesModel;
        }


        public void Add (CoursesModel model)
        {
            _dbContext.Courses.Add(new Data.Models.Courses
            {
                Id = model.Id,
                Name = model.Name,
                Duration = model.Duration,
                Teacher = model.Teacher,
                Description = model.Description
            });

            _dbContext.SaveChanges();
        }

        public void Update(CoursesModel model)
        {
            var entity = _dbContext.Courses.FirstOrDefault(x => x.Id == model.Id);
            if(entity != null)
            {
                entity.Name = model.Name;
                entity.Duration = model.Duration;
                entity.Teacher = model.Teacher;
                entity.Description = model.Description;

                _dbContext.SaveChanges();
            }
           
        }

        public void Delete(int Id)
        {
            var courseToDelete = _dbContext.Courses.Where(x => x.Id == Id).FirstOrDefault();

            if (courseToDelete != null)
            {
                _dbContext.Courses.Remove(courseToDelete);
                _dbContext.SaveChanges();
                
            }
            
            
        }

        public void Details(int Id)
        {
            var allCourses = _dbContext.Courses.ToList();
            var CoursesModel = allCourses.Select(x => new CoursesModel
            {
                Id = x.Id,
                Name = x.Name,
                Duration = x.Duration,
                Teacher = x.Teacher,
                Description = x.Description
            }).ToList();

        }

    }
}