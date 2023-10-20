using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ClothingProduct : Product

    {
        public ClothingProduct(string? prouductName, double price, int quantity,string? size) : base(prouductName, price, quantity)
        {
            Size = size;
        }
        public string? Size { get; set; }   
        public void DisplaySize()
        {
            Console.WriteLine("Size:" + Size);
        }
    }
}
