using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Entities;

namespace Vatan.Models.VM
{
    public class HomeVM
    {
        public List<User> Users { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
      
    }
}
