using System.Collections.Generic;
using System.Collections;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCode
{
    public class TestClass : BasicTestClass, ITest
    {
        

        public delegate string MyDelegate(string s, int i);

        public event MyDelegate MyEventHandler;

        public int A { get; set; }

        public TestClass(int a, int b):base(a, b)
        {
            A = a;
            b = 15;          
        }

        public void TestMethod()
        {
            MyDelegate m = (s, i) => MyMethod("test", 5);
            Console.WriteLine(m.GetType().Name);
                     
        }

        public string MyMethod(string s, int i)
        {
            return string.Empty;
        }

        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }

        public int Sum2(int a, int b)
        {
            throw new NotImplementedException();
        }

       
        public void Lambda(Action action)
        {
            Func<double, double, int> func = (x, y) => (int)(x + y);

            Console.WriteLine("Lambda: {0}", func(5, 6));
            Console.WriteLine("Lambda2 {0}", action);
        }
    }
}
