using System.IO;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SLM.Bussiness.Models
{
    public class LectureModel
    {
        public int Id { get; set; }
        public string LectureName { get; set; }

        public string LectureDescription { get;set; }

        public string LectureURL { get;set; }

        public IEnumerable<LectureModel> FileList { get; set; }

        public int CourseId { get; set; }
        
    }


    
}
