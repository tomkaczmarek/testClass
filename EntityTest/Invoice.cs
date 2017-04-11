using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class Invoice
    {
        public Invoice()
        {
            OrderItem = new List<EntityTest.OrderItem>();
        }

        public int ID { get; set; }
        public string  IssuerName { get; set; }
        public string  ReceiverName { get; set; }
        public DateTime IssueDate { get; set; }

        public List<OrderItem> OrderItem { get; set; }
    }
}
