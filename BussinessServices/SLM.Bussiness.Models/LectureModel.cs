using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLM.Bussiness.Models
{
	public class LectureModel
	{
        public LectureModel() 
        {
            Course = new CoursesModel();
        }
     
        public int Id { get; set; }
		public string LectureName { get; set; }

		public string LectureDescription { get; set; }

		public string LectureURL { get; set; }


        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual CoursesModel Course { get; set; }

    }



}
