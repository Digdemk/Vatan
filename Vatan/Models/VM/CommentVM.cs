using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Entities;

namespace Vatan.Models.VM
{
    public class CommentVM
    {
        public int ID { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Title is required!")]

        public string Title { get; set; }

        [Required(ErrorMessage = "User Name is required!")]
        [Display(Name = "User Name")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Product Name is required!")]
        [Display(Name = "Product Name")]


        public string ProductName { get; set; }
        public DateTime AddDate { get; set; }
        public List<User> users { get; set; }

        public List<Product> products { get; set; }


    }
}
