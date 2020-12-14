using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Areas.Admin.Models.ORM.Entities
{
    public class Base
    {
        public int ID { get; set; }
        bool isdelete = false;
        public bool Isdeleted
        {
            get
            {
                return isdelete;
            }
            set
            {
                isdelete = value;
            }
        }
        DateTime tarih = DateTime.Now;
        public DateTime AddDate
        {
            get
            {
                return tarih;
            }
            set
            {
                tarih = value;
            }
        }

        //public bool IsDeleted { get; set; } = false;
        //public DateTime AddDate { get; set; } = DateTime.Now;
        //public DateTime UpdateDate { get; set; } = DateTime.Now;





    }
}
