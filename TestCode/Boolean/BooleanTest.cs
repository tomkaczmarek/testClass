using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Boolean
{
    static public class BooleanTest
    {
        static public void Test()
        {
            if(MethodOne() | MethodTwo())
            {
                Console.WriteLine("Its OK");
            }

            if (MethodOne() || MethodTwo())
            {
                Console.WriteLine("Its OK");
            }
        }

        private static bool MethodOne()
        {
            return true;
        }

        private static bool MethodTwo()
        {
            return false;
        }
    }
}
