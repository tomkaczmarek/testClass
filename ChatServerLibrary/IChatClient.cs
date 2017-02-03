using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatServerLibrary
{
    public interface IChatClient
    {
        [OperationContract]
        void NotePosted(string from, string note);
    }
}
