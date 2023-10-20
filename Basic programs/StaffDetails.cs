using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class StaffDetails:College
    {
        public int Staffid {  get; set; }
        public string? Name { get; set; }
        public string? Dept { get; set; }

        public void DisplayStaffDetials()
        {
            Console.WriteLine("Id:{0}\n Name:{1}\n"+" Dept:{2}", Staffid, Name, Dept);

        }
    }
}
