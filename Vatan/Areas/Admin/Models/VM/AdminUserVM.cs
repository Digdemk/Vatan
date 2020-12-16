using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Areas.Admin.Models.VM
{
    public class AdminUserVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        public string EMail { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]
        [Compare("Password", ErrorMessage = "Please enter the same password!")]
        [Display(Name = "Confirm Password")]
        public string Confirmpassword { get; set; }

        public DateTime Lastlogindate { get; set; }
    }
}
