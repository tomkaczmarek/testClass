using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.SOLID.SRP
{
    public interface IConnection
    {
        void Dial(string c);
        void HangUp();
    }
}
