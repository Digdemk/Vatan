using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Areas.Admin.Models.ORM.Entities
{
    public class AdminUser:Base
    {
        public string EMail { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime Lastlogindate { get; set; }
        public string Roles { get; set; }

    }
}
