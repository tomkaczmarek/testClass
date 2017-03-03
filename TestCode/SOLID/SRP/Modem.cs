using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.SOLID.SRP
{
    public class Modem : IConnection, IDataChannel
    {
        public void Dial(string c)
        {
            throw new NotImplementedException();
        }

        public void HangUp()
        {
            throw new NotImplementedException();
        }

        public char Recv()
        {
            throw new NotImplementedException();
        }

        public void Send(char c)
        {
            throw new NotImplementedException();
        }
    }
}
