namespace SLM.Data.Models
{

	public class Lecture : BaseEntity
	{
        public string LectureName { get; set; }

		public string LectureDescription { get; set; }

		public string LectureURL { get; set; }
		public int CourseId { get; set; }

        


    }
}
