using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual Names Names { get; set; }
    }
}
