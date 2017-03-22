using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.CSharp7
{
    class CSharp7Class
    {
        private void TestMethod()
        {
            //local function
            Console.WriteLine(Fib(1));

            int Fib(int n) => n < 2 ? n : Fib(n - 1) + Fib(n - 2);
        }
    }
}
