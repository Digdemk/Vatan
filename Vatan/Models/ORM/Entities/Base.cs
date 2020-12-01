using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Models.ORM
{
    public class Base
    {
        [Required]
        public int ID { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
