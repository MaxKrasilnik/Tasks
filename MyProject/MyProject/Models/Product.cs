using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task9.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public int ProductCount { get; set; }
        public int Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
