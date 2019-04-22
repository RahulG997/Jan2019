using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
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
            List<Emp> lstEmp = new List<Emp>() { 
                new Emp { Empno = 1, Name = "Ram", Dept = "Dotnet", Desig = "Programmer", Basic = 42345 }, 
                new Emp {Empno=2,Name="Uday",Dept="Java",Desig="TeamLead",Basic=84233 },
                new Emp {Empno=3,Name="Kalyan",Dept="Java",Desig="Programmer",Basic=55322},
                new Emp {Empno=4,Name="Vamshi",Dept="Dotnet",Desig="Manager",Basic=85233},
                new Emp{Empno=5,Name="Prakash",Dept="Java",Desig="Programmer",Basic=82233}, 
                new Emp{Empno=6,Name="Aishwarya",Dept="Dotnet",Desig="Programmer",Basic=91233}
            };


//            foreach (Emp e in lstEmp) { }
            var res1 = from e in lstEmp select e;
            Console.WriteLine("List of Values  ");
            foreach (var v in res1)
            {
                Console.WriteLine(v.Empno + " " +v.Name + " " +v.Dept + " " +v.Desig + " " +v.Basic);
            }

            var res2 = from e in lstEmp
                       select new
                           {
                               e.Empno,e.Name,e.Basic
                           };
            Console.WriteLine("Projected Data  ");
            foreach (var v in res2)
            {
                Console.WriteLine(v.Empno + " " +v.Name + "  " +v.Basic);
            }

            Console.WriteLine("DOTNET records " );
            var res3 = from e in lstEmp where e.Dept.Equals("Dotnet") select e;
            foreach (var v in res3)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " " + v.Dept + " " + v.Desig + " " + v.Basic);
            }

            Console.WriteLine("BASIC > 60000 Records  ");
            var res4 = from e in lstEmp where e.Basic >= 60000 select e;
            foreach (var v in res4)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " " + v.Dept + " " + v.Desig + " " + v.Basic);
            }

            Console.WriteLine("Name-wise Ascending Order ");
            var res5 = from e in lstEmp orderby e.Name select e;
            foreach (var v in res5)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " " + v.Dept + " " + v.Desig + " " + v.Basic);
            }

            Console.WriteLine("Basic-Wise Descending Order  ");
            var res6 = from e in lstEmp orderby e.Basic descending select e;
            foreach (var v in res6)
            {
                Console.WriteLine(v.Empno + " " + v.Name + " " + v.Dept + " " + v.Desig + " " + v.Basic);
            }
        }
    }
}
