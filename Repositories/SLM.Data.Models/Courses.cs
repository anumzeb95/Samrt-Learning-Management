namespace SLM.Data.Models
{
    public class Courses : BaseEntity
    {
        public Courses()
        {
            // Course = new HashSet<Courses>();
            lecture = new List<Lecture>();
        }
        public string Name { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

        public string Teacher { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        public ICollection<Lecture> lecture { get; set; } //coleection navigation property

    }
}