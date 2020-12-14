using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Entities;

namespace Vatan.Areas.Admin.Models.VM
{
    public class CategoryVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Category Name is required!")]
        [Display(Name = "Category Name")]

        public string CategoryName { get; set; }

        [Required(ErrorMessage = " Top Category ID is required!")]


        public int TopCategoryID { get; set; }
        

      public List<Category> categories { get; set; }
        public string TopCategory { get; set; }


    }
}
