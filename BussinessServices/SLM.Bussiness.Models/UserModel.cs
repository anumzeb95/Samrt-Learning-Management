using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLM.Bussiness.Models
{
	public class UserModel
	{
        public UserModel()
        {
            course = new List<CoursesModel>();
        }

        public int Id { get; set; }

		public string Name { get; set; } = String.Empty;


		[Required]
		[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
		public  string Email { get; set; } = String.Empty;

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
        public string Course { get; set; } = String.Empty;

		public string Address { get; set; } = String.Empty;

		public string Contact { get; set; } = String.Empty;

		public bool RememberMe { get; set; }

        public ICollection<CoursesModel> course { get; set; }
    }
}
