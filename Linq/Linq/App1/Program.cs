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
            var x = new int[] { 12, 56, 33, 2, 67, 233 };

            var res1 = from ob in x select ob;

            Console.WriteLine("List of Values  ");
            foreach (var v in res1)
            {
                Console.WriteLine(v);
            }

            var names = new string[] {"Hanisha","Aishwarya","Prasanna","Shivani" };

            var res2 = from ob in names select ob;

            Console.WriteLine("List of Names  ");

            foreach (var v in res2)
            {
                Console.WriteLine(v);
            }
        }
    }
}
