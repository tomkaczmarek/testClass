using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class DiscountProducts
    {
        public int ID { get; set; }
        public string Discount { get; set; }

        public virtual Product Products { get; set; }
    }
}
