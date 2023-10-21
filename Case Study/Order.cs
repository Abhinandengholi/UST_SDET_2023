using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study { 

    internal class Order
    {
        Booktype[] bk=new Booktype[10];
        public string? OrderPlacedDate {  get; set; }
        public double Totalprice { get; set;}
    }
}
