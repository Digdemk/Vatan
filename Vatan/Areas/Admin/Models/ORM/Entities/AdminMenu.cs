using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Areas.Admin.Models.ORM.Entities
{
    public class AdminMenu:Base
    {
        public string Name { get; set; }
        public string Route { get; set; }
        public string IconName { get; set; }
    }
}
