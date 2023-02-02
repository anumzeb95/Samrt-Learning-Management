
using SLM.Bussiness.DataServices.Interfaces;
using SLM.Bussiness.Models;
using SLM.Data;
using SLM.Data.Interfaces;
using SLM.Data.Models;
using System.Security.Cryptography.X509Certificates;

namespace SLM.Bussiness.DataServices
{
    public class CoursesService : ICourseService
    {
        private readonly IRepository<Courses> _dbContext;
         public CoursesService(IRepository<Courses> dbContext)
        {
            _dbContext = dbContext;
        }
        public List<CoursesModel> GetAll()
        {
            var allCourses = _dbContext.GetAll();
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
            var allCourses = _dbContext.Get(x => x.Name.ToLower().Contains(searchTerm) ||
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
            _dbContext.Save(new Data.Models.Courses
            {
                Id = model.Id,
                Name = model.Name,
                Duration = model.Duration,
                Teacher = model.Teacher,
                Description = model.Description
            });

            //_dbContext.SaveChanges();
        }

        public void Update(CoursesModel model)
        {
            //var entity = _dbContext.Courses.FirstOrDefault(x => x.Id == model.Id);
            //if (entity != null)
            //{
            //    entity.Name = model.Name;
            //    entity.Duration = model.Duration;
            //    entity.Teacher = model.Teacher;
            //    entity.Description = model.Description;

            //    _dbContext.SaveChanges();
            //}

            _dbContext.Save(new Courses
            {
                Id = model.Id,
                Name = model.Name,
                Duration = model.Duration,
                Teacher = model.Teacher,
                Description = model.Description
            });
        }

        public void Delete(int Id)
        {
            var courseToDelete = _dbContext.Get(x => x.Id == Id).FirstOrDefault();

            if (courseToDelete != null)
            {
                _dbContext.Delete(courseToDelete);
                //_dbContext.SaveChanges();
                
            }
            
            
        }

        public void Details(int Id)
        {
            var allCourses = _dbContext.GetAll();
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