using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WcfBankProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BankService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BankService.svc or BankService.svc.cs at the Solution Explorer and start debugging.
    public class BankService : IBankService
    {
        public String CreateAccount(Accounts objAccounts)
        {
            SqlConnection con = new SqlConnection("integrated security=true;data source=DESKTOP-TLCGNEH;initial catalog=sqlpractice");
            con.Open();
            SqlCommand cmd = new SqlCommand("prcAccountNoGenerate",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int accno = Convert.ToInt32(dr[0]);
            cmd = new SqlCommand("prcAccountCreate",con);
            cmd.CommandType = CommandType.StoredProcedure;
            objAccounts.AccountNo = accno;
            cmd.Parameters.AddWithValue("@accountNo",objAccounts.AccountNo);
            cmd.Parameters.AddWithValue("@firstName", objAccounts.FirstName);
            cmd.Parameters.AddWithValue("@lastName", objAccounts.LastName);
            cmd.Parameters.AddWithValue("@city", objAccounts.City);
            cmd.Parameters.AddWithValue("@state", objAccounts.State);
            cmd.Parameters.AddWithValue("@amount", objAccounts.Amount);
            cmd.Parameters.AddWithValue("@cheqFacil", objAccounts.CheqFacil);
            cmd.Parameters.AddWithValue("@accountType", objAccounts.AccountType);
            cmd.ExecuteNonQuery();
            return "Accountcreated";

        }
    }
}
