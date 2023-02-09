namespace SLM.Bussiness.Models
{
    public class CoursesModel
    {
        public CoursesModel()
        {
            Lectures = new List<LectureModel>();
        }
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Duration { get; set; }= string.Empty;

        public string Teacher { get; set; } = string.Empty;

        public string Modification { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<LectureModel> Lectures { get; set; }
    }
}