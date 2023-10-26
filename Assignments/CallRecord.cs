using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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


        public static Dictionary<int, CallRecord> clr = new Dictionary<int, CallRecord>();

        public static void CallHistory(double phonenum)
        {
            foreach (var i in clr.Values)
            {
                if (phonenum == i.PhoneNumber)
                {
                    Console.WriteLine("Callid:{0}\tPhonenumber:{1}\t CallTime:{2}", i.Callid, i.PhoneNumber, i.CallTime);

                }
            }
        }
        public static void TotalCalls()
        {
            Dictionary<double, int> totalcall = new Dictionary<double, int>();
            foreach (var i in clr.Values)
            {
                if (totalcall.ContainsKey(i.PhoneNumber))
                {
                    totalcall[i.PhoneNumber]++;
                }
                else
                {
                    totalcall[i.PhoneNumber] = 1;
                }
            }
            foreach (var i in totalcall)
            {
                Console.WriteLine("phonenumber:{0}", i.Key, i.Value);
            }

        }

    }
}
