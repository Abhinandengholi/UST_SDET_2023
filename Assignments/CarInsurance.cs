using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : InsurancecPolicys
    {
        public CarInsurance(string policyName, int policyId, double premiumAmount,int cost):base(policyName,policyId,premiumAmount)
        {
            Cost = cost;
        }

        public int Cost { get; set; }
        public override double CalculatePremium()
        { if(Cost>1000000) {
                PremiumAmount += PremiumAmount * 1.2;
                return PremiumAmount;
                    }
        else { return PremiumAmount; }

        }
    }
}
