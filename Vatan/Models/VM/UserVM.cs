using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Models.VM
{
    public class UserVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please fill required areas!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please fill required areas!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please fill required areas!")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

      

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = ("Please enter the same password!"))]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please confirm your password!")]
        public string Address { get; set; }


        //[DataType(DataType.Date, ErrorMessage = "Please enter a correct format/ Enter your birthdate!")]
        //public DateTime BirthDate { get; set; }
    }
}
