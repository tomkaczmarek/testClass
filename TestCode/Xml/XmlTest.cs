using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

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

            //foreach(Customer c in customers)
            //{
            //    //first method
            //    //var customer = new XElement("Customer");
            //    //var firstNameElement = new XElement("FirstName", c.Name);
            //    //customer.Add(firstNameElement);

            //    //var ageElement = new XElement("Age", c.Age);
            //    //customer.Add(ageElement);

            //    //rootElem.Add(customer);


            //    //second method
            //    //customer = new XElement("Customer", new XElement("FirstName", c.Name, new XElement("SecondName", c.Name)), new XElement("Age", c.Age));

            //    //rootElem.Add(customer);               

            //}

            //Console.WriteLine(doc.ToString());

            //third method
            //var customerXml = new XDocument(new XElement(
            //    "Customers", from customer in customers
            //                 select new XElement("Customer", new XAttribute("FirstName", customer.Name),
            //                 new XAttribute("Age", customer.Age))));

            //Console.WriteLine(customerXml);

            //fourth method serialization and deserialization
            customers = CreateCustomer(15);

            var c = new Customer() { Name = "Tomek", Age = 15 };
            Customer c1;
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, c);
                Console.WriteLine(writer.ToString());
                c1 = serializer.Deserialize(new StringReader(writer.ToString())) as Customer;
            }

            Console.WriteLine(c1.Name);      
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

    public class Customer
    {
        [XmlAttribute]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
