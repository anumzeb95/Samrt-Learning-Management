using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLM.Data.Models
{
    internal class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "Please choose your designtion")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Please choose your course")]
        public string Course { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }
    }
}
