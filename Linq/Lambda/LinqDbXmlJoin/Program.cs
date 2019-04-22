using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace LinqDbXmlJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            DataClasses1DataContext db = new DataClasses1DataContext();
            XDocument doc = XDocument.Load("AgentPart.xml");

            //var res = from ag in db.AgentPDups
            //          join xm in doc.Descendants("AgentPart") on
            //              ag.AgentID equals Convert.ToInt32(xm.Element("AgentID").Value)
            //          select new
            //          {
            //              agid = xm.Element("AgentID").Value,
            //              add1 = ag.Address1,
            //              add2 = ag.Address2,
            //              cit = xm.Element("City").Value,
            //              st = xm.Element("State").Value
            //          };

            var res = from xm in doc.Descendants("AgentPart")
                      join ag in db.AgentPDups on
                          Convert.ToInt32(xm.Element("AgentID").Value) equals Convert.ToInt32(ag.AgentID)
                      select new
                          {
                              xm.Element("AgentID").Value,
                              ag.Address1,
                              ag.Address2,
                            
                          };
            foreach (var x in res)
            {
//                Console.WriteLine("Agent ID " +x);
                Console.WriteLine("Address 1 " + x.Address1);
                Console.WriteLine("Address 2 " + x.Address2);
                //Console.WriteLine("City " + x.cit);
                //Console.WriteLine("State " + x.st);
                Console.WriteLine("-----------------");
            }
        }
    }
}
