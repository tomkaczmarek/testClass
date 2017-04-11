using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.DataAccess
{
    public class Users : ICrudOperation<Names>
    {
        public void Add(Names users)
        {
            using (var n = new EntityTestContext())
            {
                //n.Names.Add(users);
                //n.SaveChanges();
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Names Select()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
