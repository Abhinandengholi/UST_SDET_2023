using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(string policyName, int policyId, double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string PolicyName { get; set; }
        public int PolicyId { get; set; }
        public double PremiumAmount { get; set;}

        public void RenewPolicy(double newpremium)
        {
            PremiumAmount = newpremium;
            Console.WriteLine("Renewed amount:" + PremiumAmount);
        }
        public void RenewPolicy()
        {

            double increasedampount= PremiumAmount*.10;
            PremiumAmount += increasedampount;
            Console.WriteLine("Increased amount:"+PremiumAmount);
        }
        public void Display()
        {
            Console.WriteLine("Policyid:{0}\tPolicyName:{1}\t Premiumamount:{2}", PolicyId, PolicyName, PremiumAmount);
        }
    }
}
