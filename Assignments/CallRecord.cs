using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public CallRecord(int callid, double phoneNumber, double callTime)
        {
            Callid = callid;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public int Callid { get; set; }
        public double PhoneNumber { get; set; }
        public double CallTime { get; set; }
        
    }

   
    
}
