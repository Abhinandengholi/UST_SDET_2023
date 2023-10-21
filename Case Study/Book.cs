using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Book
    { 
         
        public Book(string? title, string? author, int? iSBN, double price, bool availiability)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Price = price;
            Availiability = availiability;
        }

        public string? Title { get; set; }
        public string? Author { get; set; } 
        public int? ISBN { get; set; }
        public double Price  { get; set; }
        public bool Availiability{ get; set; }
        


    }
}
