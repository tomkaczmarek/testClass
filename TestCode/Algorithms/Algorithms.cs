using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestCode.Algorithms
{
    public static class Algorithms
    {
        public static long StrongRec(int n)
        {
            if (n < 1)
                return 1;
            return (long)(n * StrongRec(n - 1));
        } 

        public static long StrongIte(int n)
        {
            long z = 1;
            if (n < 1)
                return z;

            for(int i = 1; i<= n; i++)
            {
                z = z * i;
                if (i == 1)
                    Console.Write(i);
                else if (i > 1 && i < n)
                    Console.Write("*{0}", i);
                else
                    Console.Write("*{0}=", i);
            }
            return z;
        }

        public static int FiboRec(int n)
        {
            if (n < 1)
                return 0;
            if (n == 1 || n == 2)
                return 1;
            return FiboRec(n-1) + FiboRec(n - 2);
        }

        public static int FiboIte(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static int NWD(int a, int b)
        {
            if (a == b)
                return a;
            while(a!=b)
            {
                if (a < b)
                    b = b - a;
                else
                    a = a - b;
            }
            return a;


        }
        public static int NWW(int a, int b)
        {
            return (a * b) / NWD(a, b);
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

            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("{0} - FizzBuzz", i);
                else if (fizz)
                    Console.WriteLine("{0} - Fizz", i);
                else if (buzz)
                    Console.WriteLine("{0} - Buzz", i);
                else
                    Console.WriteLine(i);
            }
        }
    }
}
