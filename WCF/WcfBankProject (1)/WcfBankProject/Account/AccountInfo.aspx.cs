using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Account
{
    public partial class AccountInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            
            ServiceReferenceAccount.Accounts sa = new ServiceReferenceAccount.Accounts();
           // sa.AccountNo = Convert.ToInt32(txtAccountNo.Text);
            sa.FirstName = txtFirstName.Text;
            sa.LastName = txtLastName.Text;
            sa.City = txtCity.Text;
            sa.State = txtState.Text;
            sa.Amount = Convert.ToInt32(txtAmount.Text);
            sa.CheqFacil = txtCheckFacil.Text;
            sa.AccountType = txtAccountType.Text;
            ServiceReferenceAccount.BankServiceClient bankServiceClient = new ServiceReferenceAccount.BankServiceClient();
            string result = bankServiceClient.CreateAccount(sa);
            Response.Write(result);
            
        }
    }
}