using SLM.Data.Models;

namespace SLM.Bussiness.Models
{
    public class CoursesModel
    {
        public CoursesModel()
        {
            Course = new List<CoursesModel>();
        }
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

        public string Teacher { get; set; } = string.Empty;

        public string Modification { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<CoursesModel> Course { get; set; }
    }
}