using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class ListTest
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();

        public string this[int index]
        {
            get { return "Element" + index; }
            set { }
        }

        public void Test()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            FillList(list1, list2);
            list3?.AddRange(list1);
            list3?.AddRange(list2);
            
            if (list3 != null)
            {
                foreach (int i in list3)
                {
                    Console.WriteLine("Tablica: {0}", i);
                }
            }
            sw.Stop();
            Console.WriteLine("Elapsed {0}", sw.ElapsedMilliseconds);
            Console.WriteLine("List 3 {0}", list3.Count);    
        }

        public void FillList(IList<int> l1, IList<int> l2)
        {
            for(int i =0; i<1000; i++)
            {
                l1.Add(i);
                l2.Add(i * 100);
            }
        }
    }
}
