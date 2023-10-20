using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basic_programs
{
    internal class College
    {
        
        public int Collegeid { get; set; }
      
        public string? CollegeName { get; set; }
        public int CollegeEstablished { get; set; }

        public void DisplayCollegeDetials()
        {
            Console.WriteLine("CollegeId:{0}\n CollegeName:{1}\n Established:{2}\n" , Collegeid, CollegeName,CollegeEstablished);

        }
    }
}
