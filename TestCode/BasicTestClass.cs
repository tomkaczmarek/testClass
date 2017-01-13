using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class BasicTestClass
    {
        protected IList<int> ageList;

        public BasicTestClass(int a, int b)
        {
            a = 10;
            b = 15;
        }

        public virtual int Sum(int a, int b)
        {
            return 10;
        }
    }
}
