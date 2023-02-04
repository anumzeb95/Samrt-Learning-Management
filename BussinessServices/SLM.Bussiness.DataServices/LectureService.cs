
using AutoMapper;
using SLM.Bussiness.Interfaces;
using SLM.Bussiness.Models;
using SLM.Data;
using SLM.Data.Interfaces;
using SLM.Data.Models;


namespace SLM.Bussiness.DataServices
{
    public class LectureService : GenericService<LectureModel, Lecture>, ILectureService
    {
        private readonly IRepository<Lecture> _repository;
         public LectureService(IRepository<Courses> repository, IMapper mapper) : base(repository, mapper) 
         {
            _repository = repository;
         }
        


    }
}