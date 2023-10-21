using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal interface IDoctor
    {

        //public int Did { get; set; }
        //public string? DName { get; set; }

        void AddNewDoctor(int did,string? dname);
         void ModifyDoctor(int did,string? dname);
        //public void DisplayDoctorDetails();
        
    }
}
