using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Models.ORM.Entities
{
    public class Order : Base
    {
        public DateTime Date { get; set; }
        public string Shipping { get; set; }
       

       
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int BasketId { get; set; }
        [ForeignKey("BasketId")]
        public Basket Basket { get; set; }



    }
}
