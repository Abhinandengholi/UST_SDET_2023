using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study.MyException
{
   
        public class OrderException : Exception
        {
            public OrderException(string message) : base(message) { }
        }
    
}
