using Microsoft.AspNetCore.Http;
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

        [Required(ErrorMessage = "Product Name is required!")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Quantity can not be null!")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price can not be null!")]
        public double Price { get; set; }
        public List<Category> categories { get; set; }
        public CategoryCheckVM[] categoryCheck { get; set; }
        public List<IFormFile> productimages { get; set; }
        public List<string> MainImagePath { get; set; }

    }
}
