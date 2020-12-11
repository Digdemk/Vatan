using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Models.ORM.Entities
{
    public class Product : Base
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        
        
        public List<Picture> Pictures { get; set; }
        public List<Comment> Comments { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

    }
}
