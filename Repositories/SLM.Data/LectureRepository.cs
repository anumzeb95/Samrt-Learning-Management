using SLM.Data.Interfaces;
using SLM.Data.Models;

namespace SLM.Data
{
	public class LectureRepository : Repository<Lecture>, ILectureRepository
	{
		public LectureRepository(SLManagementDbContext context) : base(context)
		{

		}

	}
}
