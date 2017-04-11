using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.DataAccess
{
    public class Products : ICrudOperation<OrderItem>
    {
        public void Add(OrderItem order)
        {
            using (var o = new EntityTestContext())
            {
                o.OrderItem.Add(order);
                o.SaveChanges();
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public OrderItem Select()
        {
            OrderItem i = new OrderItem();

            using (var o = new EntityTestContext())
            {
                i = o.OrderItem.Where(z => z.ID == 1).FirstOrDefault();
            }

            return i;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
