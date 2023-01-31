using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

