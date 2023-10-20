using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class StudentDetails:College
    {
        public StudentDetails()
        {
        }

       /* public StudentDetails(int rollno,string? studName,string? city) {
            Rollno = rollno;
            StudName = student; 
             City= city;
        }
       */
        public int Rollno { get; set; } 
        public string? StudName { get; set; }
        public string? City { get; set; }
        public void DisplayStudentDetials()
        {
            Console.WriteLine("Roll Num:{0}\n Name:{1}\n city:{2}", Rollno, StudName, City);

        }
    }
}
