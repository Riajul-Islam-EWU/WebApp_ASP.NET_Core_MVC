using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ASP.NET_Core_MVC.Models
{
    public class OrderVM
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
