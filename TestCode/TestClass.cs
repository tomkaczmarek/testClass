using System.Collections.Generic;
using System.Collections;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TestCode.Exceptions;
using System.IO;

namespace TestCode
{
    public class TestClass : BasicTestClass, ITest
    { 

        public delegate string MyDelegate(string s, int i);

        public int A { get; set; }

        IList<TestClass> testClassList = new List<TestClass>();

        public TestClass()
        {
            Console.WriteLine("Konstruktor niestatyczny");
        }

        public TestClass(int a, int b):base(a, b)
        {
            A = a;
            b = 15;          
        }

        static TestClass()
        {
            Console.WriteLine("Konstruktor statyczny");
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

        public void ReflectionBase()
        {
            Type type = Type.GetType("TestCode.ClassToBranch");
            var instance = Activator.CreateInstance(type);
            MethodInfo info = type.GetMethod("HelloBranch");
            info.Invoke(instance, new object[] {"Tomek"});
            
        }

        public void DefaulTest(int maxSize, DateTime b = default(DateTime), int c = 5)
        {
            try
            {
                bool throwException = true;
                if (maxSize == 4)
                    ExceptionTestMethod(throwException);
            }
            //catch(InvalidOperationException ioEx)
            //{
            //    throw new Exception("Jakiś problem z robotem ...", ioEx);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Zapis do dziennika {0}", ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally w test class");
                Console.WriteLine("{0}, {1}, {2}", maxSize, b, c);
            }

        
        }

        public void ExceptionTestMethod(bool b)
        {
            if(b)
            {
                //throw new InvalidOperationException("Nie tędy droga");
                throw new TestException("TestException execute");
            }
        }

        public IEnumerable<string> AddNumbers(IEnumerable<string> names)
        {
            Console.WriteLine("Początek AddNumber");
            int i = 0;

            foreach (string currentNumber in names)
            {
                Console.WriteLine("W pętli addnumbers");
                yield return string.Format("{0}-{1}", i, currentNumber);
                i++;
            }

            Console.WriteLine("Koniec AddNumber");
        }

        public IEnumerable<string> GetAllFilesOnDriver(string driver)
        {
            string fullDriverName = driver;

            IEnumerable<string> files = null;
            IEnumerable<string> directories = null;

            try
            {
                files = Directory.EnumerateFiles(fullDriverName);
                directories = Directory.EnumerateDirectories(fullDriverName);
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("Błąd dostepu");
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Błąd: {0}", ex.Message);
            }
            if (files != null)
            {
                foreach (string file in files)
                {
                    yield return file;
                }
            }
            if(directories != null)
            {
                foreach(string directory in directories)
                {
                    foreach(string subdirectory in GetAllFilesOnDriver(directory))
                    {
                        yield return subdirectory;
                    }
                }
            }
        }
    }
}
