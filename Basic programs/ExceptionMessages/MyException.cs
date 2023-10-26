using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs.ExceptionMessages
{
    internal class MyException
    {
        //public static List<string> exmessagelist = new List<string>()
        //{"don't give zero for denom",
        //     "Index is out of Range" ,
        //     "Unknown exception" 
        //};

    public static Dictionary<int,string> exmessagelist = new Dictionary<int,string>()
        {
             {0, "Don't give zero for denom" },
             {1, "Index is out of Range" },
             {2, "Unknown exception" },
             {3, "Not hundred" },
             {4,"Age is more" }
        };
        internal class Number1Exception : Exception
        {
            public Number1Exception(string message) : base(message)
            { 
            }
        }
        internal class Number2Exception : Exception
        {
            public Number2Exception(string message) : base(message)
            {
            }
        }
    }
}

