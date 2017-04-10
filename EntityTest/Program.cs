using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var n = new NamesContext())
            {
                Names name = new Names() { Name = "Bart4", LastName="Test",IsLocal=true, BirthDate=DateTime.Now};
                Subject s1 = new Subject() { Name = "subject1" };
                Subject s2 = new Subject() { Name = "subject2" };
                name.Subject.Add(s1);
                name.Subject.Add(s2);

                n.Names.Add(name);


                n.SaveChanges();
            }
        }
    }
}
