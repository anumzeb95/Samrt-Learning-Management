using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLM.Bussiness.Models
{
    internal class Lecture
    {
        [Key]
        public int LectureId { get; set; }

        [Required]
        public string LectureName { get; set; }

        public int CourseId { get; set; }
        public CoursesModel Course { get; set; }
    }
}
