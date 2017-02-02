using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TestCode.Xml
{
    public class XmlTest
    {
        public void CreateXml()
        {
            XDocument doc = new XDocument();
            var rootElem = new XElement("Customers");
            doc.Add(rootElem);

            var customers = CreateCustomer(10);

            foreach(Customer c in customers)
            {
                var customer = new XElement("Customer");
                var firstNameElement = new XElement("FirstName", c.Name);
                customer.Add(firstNameElement);

                var ageElement = new XElement("Age", c.Age);
                customer.Add(ageElement);

                rootElem.Add(customer);
            }


            Console.WriteLine(doc.ToString());
        }

        private IList<Customer> CreateCustomer(int count)
        {
            IList<Customer> list = new List<Customer>();
            string[] names = new string[] { "Tomek", "Jacek", "Marcin", "Bolek", "Jarek" };           
            Random r = new Random();
            
            for(int i = 0; i<count; i++)
            {
                Customer c = new Customer()
                {
                    Age = r.Next(25, 50),
                    Name =names[r.Next(0,4)]
                };
                list.Add(c);
            }

            return list;
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
