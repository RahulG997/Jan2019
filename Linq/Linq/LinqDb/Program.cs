using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDb
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var res1 = from ob in db.Employs select ob;
            Console.WriteLine("Employ records  \n");
            foreach (var x in res1)
            {
                Console.WriteLine(x.Empno + " " +x.Name + " " +x.Dept + " " +x.Desig + " " +x.Basic);
            }

            var res2 = from ob in db.Employs
                       select new
                           {
                               ob.Empno,ob.Name,ob.Basic
                           };
            Console.WriteLine("Projected Data \n");
            foreach (var x in res2)
            {
                Console.WriteLine(x.Empno + " " +x.Name + "  " +x.Basic);
            }

            var res3 = from ob in db.Employs where ob.Dept.Equals("Dotnet") select ob;
            Console.WriteLine("\n\nDotnet records  \n");
            foreach (var x in res3)
            {
                Console.WriteLine(x.Empno + " " + x.Name + " " + x.Dept + " " + x.Desig + " " + x.Basic);
            }

            var res4 = from ob in db.Employs where ob.Basic >= 50000 select ob;
            Console.WriteLine("\n\nBasic > 50000 records  \n");
            foreach (var x in res4)
            {
                Console.WriteLine(x.Empno + " " + x.Name + " " + x.Dept + " " + x.Desig + " " + x.Basic);
            }

            var res5 = from ob in db.Employs orderby ob.Name select ob;
            Console.WriteLine("\n\n Name-wise Ascending Order  \n\n");
            foreach (var x in res5)
            {
                Console.WriteLine(x.Empno + " " + x.Name + " " + x.Dept + " " + x.Desig + " " + x.Basic);
            }

            var res6 = from ob in db.Employs orderby ob.Basic descending select ob;
            Console.WriteLine("\n\n Basic-wise Ascending Order  \n\n");
            foreach (var x in res6)
            {
                Console.WriteLine(x.Empno + " " + x.Name + " " + x.Dept + " " + x.Desig + " " + x.Basic);
            }
        }
    }
}
