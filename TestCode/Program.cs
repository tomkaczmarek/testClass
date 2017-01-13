using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool switchEx = false;

            if(switchEx)
            {
                int x = 5;
                int y = 10;
                TestClass t = new TestClass(x, y);
                MyStructur s = new MyStructur();

                Console.WriteLine(x);
                Console.WriteLine(t.A);
                Console.WriteLine(s.A);

                Change(out x);
                Change(t);
                Change(ref s);

                Console.WriteLine();

                Console.WriteLine(x);
                Console.WriteLine(t.A);
                Console.WriteLine(s.A);

                var a = 6;
                Console.WriteLine(a);

                dynamic b = 6;
                Console.WriteLine(b);
                b = "Test";
                Console.WriteLine(b);

                int firstArg = 5;
                string seconfArg = "test";
                System.Diagnostics.Stopwatch watch;
                long time;

                watch = System.Diagnostics.Stopwatch.StartNew();
                dynamic result = DynamicMethod(firstArg, seconfArg);
                watch.Stop();
                time = watch.ElapsedMilliseconds;
                Console.WriteLine("Dynamic:{0} ", time);

                watch = System.Diagnostics.Stopwatch.StartNew();
                string stringResult = NonDynamicMethod(firstArg, seconfArg);
                watch.Stop();
                time = watch.ElapsedMilliseconds;
                Console.WriteLine("NonDynamic: {0} ", time);

                Console.WriteLine(typeof(string).Assembly.ImageRuntimeVersion);

                Console.WriteLine(PrimeNumber(96));

                FizzBuzz();

                DateTime dt = new DateTime();
                TestClass test = null;
                Console.WriteLine("Test - {0}", test);

                test = new TestClass(4, 4);

                test.Lambda(test.TestMethod);
            }
            unchecked
            {
                int arg1 = Int32.MaxValue;
                int arg2 = 10;
                Console.WriteLine(arg1 + arg2);
            }


            ClassToBranch cs = new ClassToBranch();
           
            Console.ReadLine();

        }

        static public void Change(out int x)
        {
            x = 10;
        }

        static public void Change(ref MyStructur myStr)
        {
            myStr.A = 10;
        }

        static public void Change(TestClass myStr)
        {
            myStr.A = 10;
        }

        static dynamic DynamicMethod(dynamic a, dynamic b)
        {
            dynamic result = a + b;
            return result; 
        }
        static string NonDynamicMethod(int a, string b)
        {
            return a.ToString() + b;
        }

        public static bool PrimeNumber(int x)
        {
            if (x < 2) return false;
            if (x == 2) return true;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        public static void FizzBuzz()
        {

            for(int i = 1; i <=100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("{0} - FizzBuzz", i);
                else if(fizz)
                    Console.WriteLine("{0} - Fizz", i);
                else if(buzz)
                    Console.WriteLine("{0} - Buzz", i);
                else
                    Console.WriteLine(i);
            }
        }
    }
}
