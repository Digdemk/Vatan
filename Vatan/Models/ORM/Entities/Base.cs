using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Models.ORM
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
        

    }
}
