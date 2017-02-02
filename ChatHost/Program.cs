using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatServerLibrary;
using System.ServiceModel;

namespace ChatHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ChatService)))
            {
                host.Open();
                Console.WriteLine("Open");
                Console.ReadKey();
            }

        }
    }
}
