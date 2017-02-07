using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestCode.Threads
{
    public class ThreadsTest
    {
        static int count;

        public void Start()
        {
            //Thread t1 = new Thread(One);
            //Thread t2 = new Thread(Two);


            //t1.Start();
            //t2.Start();

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("Wątek główny {0}", i);
            //}

            //Thread t1 = new Thread(() => Go(new TestClass("Pierwszy")));
            //Thread t2 = new Thread(Go);            
            //t1.Start();
            //t2.Start(new TestClass("Drugi"));

            count = 0;

            Thread t1 = new Thread(() => GoMulti());
            ThreadPool.QueueUserWorkItem(Go, "Pierwszy");
            ThreadPool.QueueUserWorkItem(Go, "Drugi");

            t1.Start();

            

                     

            Go("Główny");

            Console.WriteLine(count);
        }
        
        private void One()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Wątek pierwszy {0}", i);
            }
        }

        private void Two()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Wątek drugi {0}", i);
            }
        }

        private void Go(object testClass)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Wątek: {0} - {1}", testClass, i);
            }
        }

        private void GoMulti()
        {
            for (int i = 0; i < 100; i++)
            {
                Interlocked.Increment(ref count);

            }
        }

        public class TestClass
        {
            private string _name;

            public TestClass(string name)
            {
                _name = name;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
        }
    }

    


    
}
