using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatServerLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ChatService : IChatService
    {
        private Dictionary<IChatClient, string> clientAndName = new Dictionary<IChatClient, string>();

        public bool Connect(string name)
        {
            if (clientAndName.ContainsValue(name))
                return false;

            IChatClient clientCallback = OperationContext.Current.GetCallbackChannel<IChatClient>();

            clientAndName.Add(clientCallback, name);

            Console.WriteLine("{0} - połączony", name);

            return true;
        }

        public void Disconnect()
        {
            IChatClient clientCallback = OperationContext.Current.GetCallbackChannel<IChatClient>();
            DisconnecdClient(clientCallback);
        }

        public void PostNote(string message)
        {
            IChatClient clientCallback = OperationContext.Current.GetCallbackChannel<IChatClient>();
            string name = clientAndName[clientCallback];

            KeyValuePair<IChatClient, string>[] copiedNames = clientAndName.ToArray();

            foreach(var client in copiedNames)
            {            
                if (client.Key != clientCallback)
                {
                    Console.WriteLine("Wysyłam do {0}", name);
                    try
                    {
                        client.Key.NotePosted(string.Format("{0}:", name), message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        DisconnecdClient(client.Key);
                    }
                }
            }

            Console.WriteLine("{0}: {1}", name, message);
        }

        private void DisconnecdClient(IChatClient client)
        {
            string name = clientAndName[client];
            Console.WriteLine("Rozłączony - {0}", name);
            clientAndName.Remove(client);
        }

    }
}
