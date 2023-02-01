using SLM.Bussiness.Models;


namespace SLM.Bussiness.Interfaces
{
    public interface ICourseService
    {
        List<CoursesModel> GetAll();

        public void Add(CoursesModel model);
        public void Details(int Id);
        public void Delete(int Id)
            ;
    }
}

