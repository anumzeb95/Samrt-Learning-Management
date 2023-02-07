
using AutoMapper;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.Models;
using SLM.Data;
using SLM.Data.Interfaces;
using SLM.Data.Models;
using System.Security.Cryptography.X509Certificates;

namespace SLM.Bussiness.DataServices
{
    public class CoursesService : GenericService<CoursesModel, Courses>, ICourseService
    {
        private readonly IRepository<Courses> _repository;
        public CoursesService(IRepository<Courses> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }

        


        public List<CoursesModel> Search(string searchTerm)
        {
            searchTerm = searchTerm.Trim().ToLower();
            var allCourses = _repository.Get(x => x.Name.ToLower().Contains(searchTerm) ||
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


      
        //public void Details(int Id)
        //{
        //    var allCourses = _dbContext.GetAll();
        //    var CoursesModel = allCourses.Select(x => new CoursesModel
        //    {
        //        Id = x.Id,
        //        Name = x.Name,
        //        Duration = x.Duration,
        //        Teacher = x.Teacher,
        //        Description = x.Description
        //    }).ToList();

        //}

    }
}