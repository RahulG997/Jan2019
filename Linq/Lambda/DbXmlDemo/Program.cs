using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DbXmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("user id=sa;password=Prasanna@123;data source=PRASSANA-PC;initial catalog=sqlpractice");
            SqlDataAdapter ad = new SqlDataAdapter("select * from Employ", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Employ");
            ds.WriteXml("d:\\Employ.xml");
            ad.Dispose();
            ds.Clear();
            ad = new SqlDataAdapter("select * from AgentPart", conn);
            ds = new DataSet();
            ad.Fill(ds, "AgentPart");
            ds.WriteXml("d:\\AgentPart.xml");
            Console.WriteLine("XML File Created Sucessfully...");
        }
    }
}
