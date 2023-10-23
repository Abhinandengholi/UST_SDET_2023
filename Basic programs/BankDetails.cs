using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class BankDetails
    {
         public BankDetails(int custid, long accno, string? name, string? status)
         {
             Custid = custid;
             Accno = accno;
             Name = name;
             Status = status;
         }

         
        
      /*  
        public BankDetails(int custid, long accno, string? name)
        {
            Custid = custid;
            Accno = accno;
            Name = name;
            Status = "Inactive";
        }

        public BankDetails()
        {
            Custid = 9004;
            Accno = 90489003883;
            Name = string.Empty;
            Status = "Inactive";
        }
        */
       
       
        public int Custid { get; set; }
        public long Accno { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public virtual void Welcomemessage()
        {
            Console.WriteLine("Welcome!");
        }
        //partial void ExitMessage();
        public void GetAccDetails(int custid) {
            if (Custid == custid)
                Console.WriteLine("Accno:{0}\t Name:{1}\t Status{2}", Accno, Name, Status);
            else Console.WriteLine("Acc No. does not exist");
        }
        public void GetAccDetails(long accno)
        { 
        if (Accno==accno)

                Console.WriteLine("Customerid:{0}\t Name:{1}\t Status{2}", Custid, Name, Status);
            else Console.WriteLine("Acc No. does not exist");
        }
        public void GetAccDetails(string? name)
        {
            if (Name == name)

                Console.WriteLine("Accno:{0}\t Name:{1}\t Status{2}", Accno, Name, Status);
            else Console.WriteLine("Acc No. does not exist");
        }

    }
}
