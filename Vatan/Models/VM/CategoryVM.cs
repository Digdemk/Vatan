using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Entities;

namespace Vatan.Models.VM
{
    public class CategoryVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Kategori adı boş geçilemez")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = " Üst Kategori boş geçilemez")]

        public int TopCategoryID { get; set; }

      public List<Category> categories { get; set; }
        public string TopCategory { get; set; }


    }
}
