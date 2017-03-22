using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace TestCode.Threads
{
    public class AwaitTest
    {
        public async void FooTest()
        {
            await GetResult(6).ConfigureAwait(false);
        }

        public void FooTest2()
        {
            Start(() => GetResult2());
        }

        private Task GetResult(int count)
        {
            return Task.Factory.StartNew(GetResult2);
        }

        private void GetResult2()
        {
            int count = 100;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i);
            }
        }

        private void Start(Action action)
        {
            action.Invoke();
        }

    }

    public static class TupleExtension
    {
        public static async Task<Tuple<T1,T2,T3,T4>> Transpose<T1,T2,T3, T4>(
            this Tuple<Task<T1>, Task<T2>, Task<T3>, Task<T4>> input)
        {
            return Tuple.Create(await input.Item1, await input.Item2, await input.Item3, await input.Item4);
        }

        public static TaskAwaiter<Tuple<T1,T2,T3,T4>> GetAwaiter<T1,T2,T3,T4>(
            this Tuple<Task<T1>, Task<T2>, Task<T3>, Task<T4>> input)
        {
            return input.Transpose().GetAwaiter();
        }

    }
}
