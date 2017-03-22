using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatClient.ChatServiceReference;
using System.ServiceModel;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string message;
            bool nameConnect = false;
            Console.WriteLine("Podaj imię:");
            

            ChatCallback callbackObject = new ChatCallback();
            InstanceContext clientContex = new InstanceContext(callbackObject);
            using (ChatServiceClient proxy = new ChatServiceClient(clientContex))
            {
                while (!nameConnect)
                {
                    name = Console.ReadLine();
                    nameConnect = proxy.Connect(name);
                    if (!nameConnect)
                        Console.WriteLine("Imię istnieje - spróbuj jeszcze raz");
                    else
                        Console.WriteLine("Witaj {0} - możesz pisać", name);
                }

                while(true)
                {
                    message = Console.ReadLine();
                    proxy.PostNote(message);

                    if (string.IsNullOrEmpty(message))
                        break;
                }

                proxy.Disconnect();
            }
            Console.ReadLine();

            
        }

        static void DoMessage(string message)
        {
            
        }
    }
}
