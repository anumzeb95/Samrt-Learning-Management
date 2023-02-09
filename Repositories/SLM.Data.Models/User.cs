using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLM.Data.Models
{
	public class User : BaseEntity
	{
        public User()
        {
            course = new List<Courses>();
        }

        public string Name { get; set; } = String.Empty;


        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        [RegularExpression(@"^([a-zA-Z0-9^_\+.-{2,6}$@*#]{8,15})$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 " +
            "UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
        public string Password { get; set; } = String.Empty;

        public string DOB { get; set; } = String.Empty;

        public string Gender { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please choose your designtion")]
        public string Designation { get; set; } = String.Empty;


        [ForeignKey("Courses")] 
        public String Course { get; set; } = String.Empty;

        //public Courses Course { get; set; }
        public string Address { get; set; } = String.Empty;

        public string Contact { get; set; } = String.Empty;

        public bool RememberMe { get; set; }

        public ICollection<Courses> course { get; set; }

    }
}
