using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ASP.NET_Core_MVC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductDetails { get; set; }
        public string ProductImage { get; set; }
        public string DisplaySize { get; set; }
        public bool isActive { get; set; }

        public virtual Category Category { get; set; }
    }
}
