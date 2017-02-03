using ChatClient.ChatServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ChatCallback : IChatServiceCallback
    {
        public void NotePosted(string from, string note)
        {
            Console.WriteLine("{0} {1}", from, note);
        }
    }
}
