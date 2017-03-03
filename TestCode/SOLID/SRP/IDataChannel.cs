using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.SOLID.SRP
{
    public interface IDataChannel
    {
        void Send(char c);
        char Recv();
    }
}
