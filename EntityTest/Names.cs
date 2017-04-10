using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    public class Names
    {
        public Names()
        {
            Subject = new List<Subject>();
        }

        public int ID { get; set; }
        public string Name{ get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsLocal { get; set; }

        public virtual List<Subject> Subject { get; set; }

    }
}
