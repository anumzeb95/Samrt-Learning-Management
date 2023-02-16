using SLM.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLM.DependencyInjection.OptionModels
{
    internal class AccountOption
    {
        public string Name { get; set; }= string.Empty;
        public string Email { get; set; }= string.Empty;
        public string Password { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string RememberMe { get; set; } = string.Empty;

   
    }
}
