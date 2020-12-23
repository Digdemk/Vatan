using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Entities;

namespace Vatan.Areas.Admin.Models.VM
{
    public class OnyuzProductVM
    {
        public int ID { get; set; }

        public List<Product> products { get; set; }
        
    }
}
