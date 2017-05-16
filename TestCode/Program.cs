using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCode.Threads;
using TestCode.Html;

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

                Console.WriteLine(Algorithms.Algorithms.PrimeNumber(96));

                Algorithms.Algorithms.FizzBuzz();

                TestClass test = null;
                Console.WriteLine("Test - {0}", test);

                test = new TestClass(4, 4);

                test.Lambda(test.TestMethod);

                unchecked
                {
                    int arg1 = Int32.MaxValue;
                    int arg2 = 10;
                    Console.WriteLine(arg1 + arg2);
                }

                try
                {
                    TestClass test2, test3;

                    test2 = new TestClass();
                    test3 = new TestClass();

                    test2.ReflectionBase();

                    test2.DefaulTest(maxSize: 4);

                    TestClass t1 = new TestClass();
                    TestClass t2 = new TestClass();

                    t2 = t1;

                    t2.A = 200;

                    t1.A = 100;

                    Console.WriteLine(t2.A);

                    int[] tab = { 2, 1, 3, 5 };
                    foreach (int i in tab)
                        Console.WriteLine(i);

                    Array.Sort(tab);

                    foreach (int i in tab)
                        Console.WriteLine(i);

                    ListTest li = new ListTest();
                    li.Test();

                    GenericClass<TestClass> testClass = new GenericClass<TestClass>();
                    testClass.Add(new TestClass() { A = 100 });
                    testClass.Add(new TestClass() { A = 200 });
                    testClass[1].A = 1200;

                    foreach (TestClass t5 in testClass)
                    {
                        Console.WriteLine(t5.A);
                    }
                    GenericClass<ListTest> lisTest = new GenericClass<ListTest>();

                    foreach (ListTest lt in lisTest)
                    {

                    }

                    

                    TestClass t7 = new TestClass();
                    string str = t7.Ext();

                    LinqTest ltest = new LinqTest();
                    ltest.SelectManyTest();

                    AlgorithmsTest();

                    StreamTest();

                    FunWithBoolean();

                    ActionTest();

                    XmlTest();

                    ThreadsFun();


                    AwaitTest awaittest = new AwaitTest();
                    awaittest.FooTest();
                    awaittest.FooTest2();
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine("Wystąpił błąd: {0}", ioex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Jesteśmy w Exception");
                    Exception current = ex;
                    while (current != null)
                    {
                        Console.WriteLine(current.Message);
                        current = current.InnerException;
                    }

                }
                finally
                {
                    Console.WriteLine("Czekam w finally");
                }
            }


            Html.TagsGenerator tags = new TagsGenerator();
            Console.WriteLine(tags.Generate("test"));
            Console.ReadLine();
           
        }


        #region Old

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

        

        static IEnumerable<string> GetString(IEnumerable<TestClass> t2)
        {
            foreach (TestClass t in t2)
            {
                yield return string.Format("{0}", t.A);
            }
        }

        static IEnumerable<string> AddNumbers(IEnumerable<string> names)
        {
            int i = 0;

            foreach (string currentNumber in names)
            {
                yield return string.Format("{0}-{1}", i, currentNumber);
            }
        }

        static void EqualsRef()
        {
            string abc = "abc";
            string abc2 = "abc";
            TestClass tc1 = new TestClass();
            TestClass tc2 = new TestClass();
            tc1 = tc2;
            string abc3 = "abc3";
            string abc4 = abc3.Substring(0, 3);

            TestClass tc3 = new TestClass();
            TestClass tc4 = new TestClass();
            tc3.A = 5;
            tc4.A = 5;

            if (tc1 == tc2)
            {
                Console.WriteLine("Pasują1");
            }
            if (object.ReferenceEquals(tc1, tc2))
            {
                Console.WriteLine("Pasują2");
            }

            if (object.Equals(abc, abc2))
            {
                Console.WriteLine("Pasują3 ref {0}, ref {1}", abc.GetHashCode(), abc2.GetHashCode());
            }
            if (abc == abc2)
            {
                Console.WriteLine("Pasują4");
            }
            if (abc == abc4)
            {
                Console.WriteLine("Pasują5");
            }
            if (object.ReferenceEquals(abc, abc4))
            {
                Console.WriteLine("Pasują6");
            }

            if (object.Equals(abc, abc4))
            {
                Console.WriteLine("Pasują7 ref {0}, ref {1}", abc.GetHashCode(), abc4.GetHashCode());
            }
            if (tc3.A == tc4.A)
            {
                Console.WriteLine("Pasują8 ref {0}, ref {1}", tc3.A.GetHashCode(), tc4.A.GetHashCode());
            }
            if (tc3.A.Equals(tc4.A))
            {
                Console.WriteLine("Pasują9");
            }
            if (object.ReferenceEquals(tc3.A, tc4.A))
            {
                Console.WriteLine("Pasują10");
            }
        }

        static void YieldEx()
        {
            string[] events = { "test1", "test2", "test3" };

            IEnumerable<string> myEvents = AddNumbers(events);

            TestClass t6 = new TestClass();
            Console.WriteLine("Wywołujemy metodę Addnumber");
            var ienumerable = t6.AddNumbers(events);
            Console.WriteLine("Zaczynamy");
            foreach (string z in ienumerable)
            {
                Console.WriteLine("W pętli głównej {0}", z);
            }
            Console.WriteLine("Kończymy");

            var directory = t6.GetAllFilesOnDriver(@"F:\");

            foreach (string z in directory)
            {
                Console.WriteLine(z);
            }
        }

        static void AlgorithmsTest()
        {
            System.Diagnostics.Stopwatch w, z;

            Console.WriteLine("Silnia rekurencyjnie");
            w = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(Algorithms.Algorithms.StrongRec(21));
            w.Stop();
            Console.WriteLine(w.ElapsedMilliseconds);

            z = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Silnia iteracyjnie");
            Console.WriteLine(Algorithms.Algorithms.StrongIte(21));
            z.Stop();
            Console.WriteLine(z.ElapsedMilliseconds);

            Console.WriteLine("Liczby fibonnaciego");
            Console.WriteLine(Algorithms.Algorithms.FiboRec(6));
            Console.WriteLine(Algorithms.Algorithms.FiboIte(3));
            Console.WriteLine(Algorithms.Algorithms.FiboIte(6));
            Console.WriteLine("Algorytm Euklidesa");
            Console.WriteLine(Algorithms.Algorithms.NWD(24, 6));
            Console.WriteLine("NWW");
            Console.WriteLine(Algorithms.Algorithms.NWW(192, 348));

        }

        static void StreamTest()
        {
            Streams.Streams streams = new Streams.Streams();

            string encrypt, descrypt;

            encrypt = streams.EncryptString("Tomek");
            descrypt = streams.DescriptString(encrypt);

            Console.WriteLine("Text: Tomek{0}Encrypt: {1}{0}Descript: {2}", Environment.NewLine, encrypt, descrypt);

        }

        static void FunWithBoolean()
        {
            Boolean.BooleanTest.Test();
        }

        static void ActionTest()
        {
            Providers.TestProviders test = new Providers.TestProviders();
            string s = "test";
            test.RunProvider(() => TestAction(s));
        }

        static void TestAction(string t)
        {
            Console.WriteLine(t);
        }

        static void XmlTest()
        {
            Xml.XmlTest xml = new Xml.XmlTest();
            xml.CreateXml();
        }

        #endregion

        #region 2017/02/07

        static void ThreadsFun()
        {
            ThreadsTest threadsTest = new ThreadsTest();
            threadsTest.Start();
        }

        #endregion
    }
}
