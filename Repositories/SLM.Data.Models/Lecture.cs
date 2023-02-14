using System.ComponentModel.DataAnnotations.Schema;

namespace SLM.Data.Models
{

	public class Lecture : BaseEntity
	{
		public Lecture() 
		{
			Course = new Courses();
		}

        public string LectureName { get; set; }

		public string LectureDescription { get; set; }

		public string LectureURL { get; set; }
		public int CourseId { get; set; }
        [ForeignKey("CourseId")]

        public virtual Courses Course { get; set; }
        


    }
}
