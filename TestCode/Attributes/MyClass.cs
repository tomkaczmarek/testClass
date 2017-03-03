using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Attributes
{
    public class MyClass
    {
        [Test(123, "Fix", Comment ="My fix")]
        public MyClass()
        {

        }
    }
}
