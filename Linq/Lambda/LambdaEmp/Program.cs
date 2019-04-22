using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEmp
{
    class Emp
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }
        public int Basic { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> lstEmp = new List<Emp>()
            {
                new Emp{Empno=1,Name="Siddharth",Dept="Dotnet",Desig="Programmer",Basic=48843},
                new Emp{Empno=2,Name="Naveen",Dept="Java",Desig="Programmer",Basic=64444},
                new Emp{Empno=3,Name="Rajesh",Dept="Dotnet",Desig="Programmer",Basic=64433},
                new Emp{Empno=4,Name="Guru",Dept="SQL",Desig="Programmer",Basic=56777},
                new Emp{Empno=5,Name="Sai",Dept="Dynamics",Desig="TeamLead",Basic=99999} 
            };

            var res1 = lstEmp.Select(x => x);

            Console.WriteLine("Lists of Values  ");
            foreach (var v in res1)
            {
                Console.WriteLine(v.Empno + " " +v.Name + " " +v.Dept + " " +v.Desig + " " +v.Basic);
            }

            Console.WriteLine("Projected Data is  \n\n");
            var res2 = lstEmp.Select(x => new {x.Empno,x.Name,x.Basic });

            foreach (var v in res2)
            {
                Console.WriteLine(v.Empno + " " +v.Name + " " +v.Basic);
            }

            var res3 = lstEmp.Select(x => x).Where(x => x.Basic >= 50000);

            Console.WriteLine("Conditional Data is  ");
            foreach (var v in res3)
            {
                Console.WriteLine(v.Empno + " " +v.Name + " " +v.Dept + " " +v.Desig + " " +v.Basic);
            }

            var res4 = lstEmp.Select(x => x).OrderBy(x => x.Name);
            Console.WriteLine("Order By Ascending Order \n\n\n");
            foreach (var v in res4)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " " + v.Dept + " " + v.Desig + " " + v.Basic);
            }

            var res5 = lstEmp.Select(x => x).OrderByDescending(x => x.Basic);
            Console.WriteLine("Order By Descending Order \n\n\n");
            foreach (var v in res5)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " " + v.Dept + " " + v.Desig + " " + v.Basic);
            }
        }
    }
}
