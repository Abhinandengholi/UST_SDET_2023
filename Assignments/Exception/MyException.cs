using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionMesages
{
    internal class MyException
    {
        public static Dictionary<int, string> excpmsg = new Dictionary<int, string>()
        {
             {0, "Patient nam and Diagnoid should not be null or empty" },
             {1, "Treatment cost should be positive value" },

        };
    }
    internal class InvalidPatientDataException : Exception
    {
        public InvalidPatientDataException(string message) : base(message)
        {
        }
    }
    internal class InvalidMedicalDataException : Exception
    {
        public InvalidMedicalDataException(string message) : base(message)
        {
        }
    }
}


