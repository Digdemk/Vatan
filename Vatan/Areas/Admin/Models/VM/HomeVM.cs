using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Entities;


namespace Vatan.Areas.Admin.Models.VM
{
    public class HomeVM
    {
        public List<User> Users { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<AdminUser> AdminUsers { get; set; }
      
    }
}
