using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class EntityTestContext : DbContext
    {
        //public DbSet<Names> Names { get; set; }
        //public DbSet<Subject> Subject { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<DiscountProducts> DiscountProducts { get; set; }
    }
}
