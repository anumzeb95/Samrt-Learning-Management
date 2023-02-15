using SLM.Bussiness.Models;

namespace SLM.Bussiness.Interfaces
{
	public interface ILectureService : IGenericService<LectureModel>
	{
        //void Download(int id);

        //List<LectureModel> FormFile (IFormFile formFile)

        public List<LectureModel> LectureForCourse(int CourseId);
    }
}
