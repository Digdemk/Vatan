using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Areas.Admin.Models.VM
{
    public class LoginVM
    {
        [Required(ErrorMessage = "EMail alanı boş geçilemez")]
        public string EMail { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
