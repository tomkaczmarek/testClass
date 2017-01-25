using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class LinqTest
    {

        public void SelectManyTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6};

            var multi = from x in numbers
                        from y in numbers
                        select x * y;

            foreach(int n in multi)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();

            multi = numbers.SelectMany(x => numbers, (x, y) => x * y);

            foreach (int n in multi)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();

            int agg = numbers.Aggregate(0, (x, y) => x + 1);
            Console.WriteLine(agg);


            double avv = numbers.Aggregate(
                new { Total = 0.0, Count = 0 },
                (agg1, sum) => new
                {
                    Total = agg1.Total + sum,
                    Count = agg1.Count + 1
                },
                (agg1) => agg1.Total / agg1.Count);

            Console.WriteLine(avv);

            
        }
    }
}
