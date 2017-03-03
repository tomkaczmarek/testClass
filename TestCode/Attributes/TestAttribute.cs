using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Attributes
{
    [AttributeUsage(AttributeTargets.Constructor,AllowMultiple =true)]
    public class TestAttribute : Attribute
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Comment { get; set; }

        public TestAttribute(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        
    }
}
