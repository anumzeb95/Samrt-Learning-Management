using System.ComponentModel.DataAnnotations;

namespace SLM.Bussiness.Models
{
	internal class Contact
	{
		[Required]
		public string ContactName { get; set; }

		[Key]
		[Required]
		public string ContactEmail { get; set; }
		[Required]
		public string ContactMessage { get; set; }
	}
}

