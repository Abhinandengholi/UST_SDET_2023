using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : InsurancecPolicys
    {
        public LifeInsurance(string policyName, int policyId, double premiumAmount,int age):base(policyName,policyId,premiumAmount)
        {
            Age = age;
        }
        public int Age { get; set; }
        public override double CalculatePremium()
        {
            if (Age > 55)
            {
                PremiumAmount += PremiumAmount * 0.8;
                return PremiumAmount;
            }
            else { return PremiumAmount; }
    }
    }
}
