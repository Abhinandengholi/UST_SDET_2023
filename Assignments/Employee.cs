using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee:Person,IDisplayable
    {
        public Employee(int employeeid,string? firstname, string? lastname, int? age) : base(firstname, lastname, age)
        { 
            Employeid= employeeid;
        }

        public int Employeid { get; set; }
        
            public void DisplayInfo()
        {
            Console.WriteLine("Age limit is betwen 18 and 100");
            Console.WriteLine("Full name:{0}\n Age:{1}", Firstname + Lastname,Age);

        }
    }
}
