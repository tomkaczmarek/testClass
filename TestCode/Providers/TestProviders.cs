using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Providers
{
    public class TestProviders
    {
        public void RunProvider(Action action)
        {
            action.Invoke();
        }

    }
}
