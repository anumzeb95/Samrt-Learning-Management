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
        private readonly IRepository<Lecture> _repositry;

        public LectureService(IRepository<Lecture> repository, IMapper mapper) : base(repository, mapper)
        {
            _repositry = repository;
        }

        public List<LectureModel> LectureForCourse(int CourseId)
        {
            var lectureQurable = _repositry.Get(x => x.CourseId == CourseId);

            
            var lectureModels = lectureQurable.Select(x => new LectureModel
            { Id = x.Id,
              LectureName = x.LectureName,
              LectureDescription = x.LectureDescription,
                LectureURL = x.LectureURL,
                CourseId = x.CourseId

            }).ToList();
            return lectureModels;
        }

        

    }
}



