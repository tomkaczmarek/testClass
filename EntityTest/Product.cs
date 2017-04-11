using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class Product
    {
        public Product()
        {
            OrderItem = new List<EntityTest.OrderItem>();
            DiscountProducts = new List<EntityTest.DiscountProducts>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double BasePrice { get; set; }
        public float Tax { get; set; }

        public virtual List<OrderItem> OrderItem { get; set; }
        public virtual List<DiscountProducts> DiscountProducts { get; set; }
    }
}
