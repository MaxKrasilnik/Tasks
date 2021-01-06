using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task9.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public int Price { get; set; }
        public int ProductCount { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
