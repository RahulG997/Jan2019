using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaJoinDbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            var res = ctx.Agents.Join(ctx.AgentPolicies, a => a.AgentID, ap => ap.AgentID, (a, ap) => new
            {
                a.AgentID,
                a.FirstName,
                a.LastName,
                a.City,
                a.STATE,
                a.Address1,
                ap.PolicyID
            }).Join(ctx.Policies, jn => jn.PolicyID, p => p.PolicyID, (jn, p) => new 
            {
                jn.AgentID,p.PolicyID,jn.FirstName,jn.LastName,jn.City,jn.STATE,
                p.ModalPremium,p.PaymentModeID,p.AnnualPremium,p.AppNumber
            });

            Console.WriteLine("Consolidated Data is  ");
            foreach (var x in res)
            {
                Console.WriteLine(x.AgentID + "  " +x.FirstName + " " +x.LastName + " " +x.City + " " +x.PolicyID + " " +x.ModalPremium + " " +x.AnnualPremium + " " +x.PaymentModeID + "  " +x.AppNumber);
            }
        }
    }
}
