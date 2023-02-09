namespace SLM.Data.Models
{
    public class Courses : BaseEntity
    {
        public Courses()
        {
            Lectures = new List<Lecture>();
        }
        public string Name { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

        public string Teacher { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<Lecture> Lectures { get; set; }

        //public int UserId { get; set; }
        //public User User { get; set; }

    }
}