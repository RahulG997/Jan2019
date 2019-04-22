using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 2, 66, 23, 3, 623, 626 };

            //var res = from ob in x select ob;
            var res1 = x.Select(ob => ob);
            foreach (var v in res1)
            {
                Console.WriteLine(v);
            }

            string[] names = new string[] {"Hari","Karunya","Vinod","Aishwarya" };

            var res2 = names.Select(ob => ob);
            foreach (var v in res2)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Sorted Data \n");
            var res3 = names.Select(ob => ob).OrderBy(ob => ob);
            foreach (var v in res3)
            {
                Console.WriteLine(v);
            }

            var res4 = names.Select(ob => ob).OrderByDescending(ob => ob);
            Console.WriteLine("Order By Desceding \n\n");
            foreach (var v in res4)
            {
                Console.WriteLine(v);
            }

          
            //var res = from ob in x select ob;
            //foreach (var v in res)
            //{
            //    Console.WriteLine(v);
            //}
        }
    }
}
