using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaJoinEx
{
    class Emp
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }
        public int Basic { get; set; }
    }

    class Depts
    {
        public string Dept { get; set; }
        public string Branch { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> lstEmp = new List<Emp>(){
                new Emp{Empno=1,Name="Siddharth",Dept="Dotnet",Desig="Programmer",Basic=48843},
                 new Emp{Empno=2,Name="Naveen",Dept="Java",Desig="Programmer",Basic=64444},
 new Emp{Empno=3,Name="Rajesh",Dept="Dotnet",Desig="Programmer",Basic=64433},
 new Emp{Empno=4,Name="Guru",Dept="SQL",Desig="Programmer",Basic=56777},
 new Emp{Empno=5,Name="Sai",Dept="Dynamics",Desig="TeamLead",Basic=99999} };

            List<Depts> lstDepts = new List<Depts>()
    {
        new Depts{Dept="Dotnet",Branch="Madhapur",City="Hyderabad"},
        new Depts{Dept="Java",Branch="Ameerpet",City="Hyderabad"},
        new Depts{Dept="SQL",Branch="JayaNagar",City="Bangalore"},
        new Depts{Dept="Dynamics",Branch="Banjara Hills",City="Hyderabad"}
    };

            var joinData=lstDepts.Join(lstEmp, d=>d.Dept,e =>e.Dept, (d,e) => new 
            {
                d.Dept,d.City,e.Empno,e.Name,e.Basic
            });

            Console.WriteLine("Consolidated Data is  ");
            foreach (var x in joinData)
            {
                Console.WriteLine(x.Empno + " " +x.Name + " " +x.Dept + "  " +x.City + " " +x.Basic);
            }

        }
    }
}
