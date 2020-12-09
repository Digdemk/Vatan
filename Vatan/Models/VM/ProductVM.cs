using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Entities;

namespace Vatan.Models.VM
{
    public class ProductVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Ürün adı boş geçilemez")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Ürün açıklaması boş geçilemez")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Ürün adedi boş geçilemez")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Ürün fiyatı boş geçilemez")]
        public double Price { get; set; }
        public List<Category> categories { get; set; }

    }
}
