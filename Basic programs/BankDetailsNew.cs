using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int custid, long accno, string? name, string? status) : base(custid, accno, name, status)
        {
        }
        public override void Welcomemessage()//creating new instance for the welcomemessage()
        {
            Console.WriteLine("Welcome! {0}", Name);
        }
        //    public new void ExitMessage()
        //    {

        //        Console.WriteLine("Done");

        //    }
        //}
    }
}