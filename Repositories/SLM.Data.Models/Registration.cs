using System.ComponentModel.DataAnnotations;

namespace SLM.WebApp.Models
{
    public class Registration
    {
        public int Id { get; set; }

        public string Name { get; set; }= String.Empty;

        public string Email { get; set; }= String.Empty;

        public string Password { get; set; } = String.Empty;

        public string DOB { get; set; } = String.Empty;

        public string Gender { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please choose your designtion")]
        public string Designation { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please choose your course")]
        public string Course { get; set; }= String.Empty;

        public string Address { get; set; } = String.Empty;

        public string Contact { get; set; } = String.Empty;

    }
}
