using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class Doctor:IDoctor
    {
        public int Did { get; set; }
        public string? DName { get; set; }

        public void AddNewDoctor(int did,string? dname)
        {
            Did = did;DName = dname;
        }

        public void ModifyDoctor(int did,string? dname)
        {
            Did = did; DName = dname;
        }
        public void BookApp(int did, string? pname) {
            Console.WriteLine("Book app  for {0} with docotr{1}",pname,did);
        }
        public void DelApp( string? pname)
        {
            Console.WriteLine("delete app for{0} ",pname);
        }
        public void DisplayDoctorDetails()
        {
            Console.WriteLine("Doctor id:{0}\t Name::{1}\t", Did, DName);
        }
    }
}
