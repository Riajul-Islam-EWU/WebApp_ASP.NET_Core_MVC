using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ASP.NET_Core_MVC.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [Display(Name ="Product Name")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Range(minimum:1,maximum:10)]
        public int OrderQuantity { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
