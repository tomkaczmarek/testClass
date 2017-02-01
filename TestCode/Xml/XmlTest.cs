using System;
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


            Console.WriteLine(doc.ToString());
        }
    }
}
