using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatServerLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChatService" in both code and config file together.
    [ServiceContract(CallbackContract =typeof(IChatClient), SessionMode = SessionMode.Required)]
    public interface IChatService
    {
        [OperationContract]
        void PostNote(string message);
        [OperationContract]
        bool Connect(string name);
        [OperationContract]
        void Disconnect();
    }
}
