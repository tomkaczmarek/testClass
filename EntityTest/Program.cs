using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTest.DataAccess;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Products p = new Products();
            OrderItem orderItem = new OrderItem();
            if (false)
            {
                orderItem = new OrderItem() { Number = "PO1234" };
                Product p1 = new Product() { BasePrice = 5.1, Name = "Baton", Description = "Dobry baton", Tax = 2.1f };
                DiscountProducts discountp = new DiscountProducts() { Discount = "Discount" };
                Invoice invoice = new Invoice() { IssueDate = DateTime.UtcNow, IssuerName = "Tomek", ReceiverName = "Name" };

                p1.DiscountProducts.Add(discountp);
                orderItem.Products = p1;
                orderItem.Invoices = invoice;
                p.Add(orderItem);
            }
            orderItem = p.Select();
          
        }
    }
}
