using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public abstract class AbstractTestClass
    {
        int Sum(int a, int b)
        {
            return a + b;
        }

        public abstract int AbstractSum(int a, int b);


    }
}
