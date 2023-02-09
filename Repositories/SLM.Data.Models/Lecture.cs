namespace SLM.Data.Models
{

	public class Lecture : BaseEntity
	{
		public Lecture()
		{
			Lectures = new List<Lecture>();
		}

		public int Id { get; set; }
		public string LectureName { get; set; }

		public string LectureDescription { get; set; }

		public string LectureURL { get; set; }
		public int CourseId { get; set; }

		public ICollection<Lecture> Lectures { get; set; }


	}
}
