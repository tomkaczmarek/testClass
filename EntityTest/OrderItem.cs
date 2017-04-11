using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class OrderItem
    {
        public int ID { get; set; }
        public string  Number { get; set; }

        public virtual Product Products { get; set; }
        public virtual Invoice Invoices { get; set; }
    }
}
