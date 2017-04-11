using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.DataAccess
{
    public interface ICrudOperation<T>
    {
        void Add(T type);
        T Select();
        void Update();
        void Delete();
    }
}
