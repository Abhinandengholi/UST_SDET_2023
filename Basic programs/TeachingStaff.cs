using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class TeachingStaff : StaffDetails
    {
        public string? Specializations { get; set; }
        public int sem { get; set; }
        public void DisplayTSStaffDetails()
        { Console.WriteLine("Spec:{0}\n sem:{1}", Specializations, sem);
        }
    }
}
