using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            var res1 = ctx.Agents.Select(x => x);
            Console.WriteLine("All Agent records  ");
            foreach (var x in res1)
            {
                Console.WriteLine(x.AgentID + " " +x.FirstName + " " +x.LastName + " " +x.City + " " +x.STATE);
            }

            Console.WriteLine("Projected Data is \n\n\n\n");
            var res2 = ctx.Agents.Select(x => new {x.AgentID,x.FirstName,x.LastName,x.SSN,x.DOB });

            foreach (var x in res2)
            {
                Console.WriteLine(x.AgentID + " " +x.FirstName + " " +x.LastName + "  " +x.SSN + "  " +x.DOB);
            }

            var res3 = ctx.Agents.Select(x => x).Where(x => x.AgentID >= 5);

            Console.WriteLine("Filtered Data is  ");
            foreach (var x in res3)
            {
                Console.WriteLine(x.AgentID + "  " +x.FirstName + " " +x.LastName + " " +x.City + " " +x.STATE);
            }

            var res4 = ctx.Agents.Select(x => x).OrderBy(x => x.FirstName);
            Console.WriteLine("Sorted Data is \n\n\n\n");
            foreach (var x in res4)
            {
                Console.WriteLine(x.AgentID + "  " + x.FirstName + " " + x.LastName + " " + x.City + " " + x.STATE);
            }

            var res5 = ctx.Agents.Select(x => x).OrderByDescending(x => x.FirstName);
            Console.WriteLine("Sort By Descending Order \n\n\n");
            foreach (var x in res5)
            {
                Console.WriteLine(x.AgentID + "  " + x.FirstName + " " + x.LastName + " " + x.City + " " + x.STATE);
            }
        }
    }
}
