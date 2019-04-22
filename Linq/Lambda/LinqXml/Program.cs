using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace LinqXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("Employ.xml");
            var res1 = from xm in doc.Descendants("Employ") select xm;
            Console.WriteLine("Xml Data is  ");
            foreach (var x in res1)
            {
                Console.WriteLine("Employ No " +x.Element("Empno").Value);
                Console.WriteLine("Name " + x.Element("Name").Value);
                Console.WriteLine("Department " + x.Element("Dept").Value);
                Console.WriteLine("Desig " + x.Element("Desig").Value);
                Console.WriteLine("Basic " + x.Element("Basic").Value);
                Console.WriteLine("-------------------------");
            }

            var res2 = from xml in doc.Descendants("Employ") where Convert.ToInt32(xml.Element("Basic").Value) >= 80000 select xml;

            Console.WriteLine("\n\n\n\nFiltered Data is  ");
            foreach (var x in res2)
            {
                Console.WriteLine("Employ No " + x.Element("Empno").Value);
                Console.WriteLine("Name " + x.Element("Name").Value);
                Console.WriteLine("Department " + x.Element("Dept").Value);
                Console.WriteLine("Desig " + x.Element("Desig").Value);
                Console.WriteLine("Basic " + x.Element("Basic").Value);
                Console.WriteLine("-------------------------");
            }

            var res3 = from xm in doc.Descendants("Employ") orderby xm.Element("Name").Value select xm;
            Console.WriteLine("\n\n\nSorted Data is  ");
            foreach (var x in res3)
            {
                Console.WriteLine("Employ No " + x.Element("Empno").Value);
                Console.WriteLine("Name " + x.Element("Name").Value);
                Console.WriteLine("Department " + x.Element("Dept").Value);
                Console.WriteLine("Desig " + x.Element("Desig").Value);
                Console.WriteLine("Basic " + x.Element("Basic").Value);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
