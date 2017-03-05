using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadTest t = new ThreadTest();

            var i = t.MyMethosAsync();

            Console.ReadLine();

        }
    }
}
