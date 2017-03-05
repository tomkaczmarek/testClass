using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Threading
{
    public class ThreadTest
    {
        public async Task MyMethosAsync()
        {
            Task<int> longRunningTask = LongRunningOperation();

            int result = await longRunningTask;

            Console.WriteLine(result);
        }

        private async Task<int> LongRunningOperation()
        {
            await Task.Delay(2000);
            return 1;
        }
    }
}
