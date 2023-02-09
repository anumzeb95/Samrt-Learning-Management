using SLM.Data.Interfaces;
using SLM.Data.Models;


namespace SLM.Data
{
    public class CourseRepository : Repository<Courses>, ICourseRepository
    {
        public CourseRepository(SLManagementDbContext context) : base(context)
        {

        }

    }
}
