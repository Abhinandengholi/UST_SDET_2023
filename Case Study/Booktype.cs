using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Booktype:Book
    {
        public string? Genre { get; set; }
        public Booktype(string? title, string? author, int? iSBN, double price, bool availiability,string? genre) : base(title, author, iSBN, price, availiability)
        {
            this.Genre = genre;


        }
        public void DisplayDetails() {

            Console.WriteLine("Book Title is:{0}\n Author Name is:{1}\n Isbn is:{2}\n Price of the book is:{3}\n Availiabilty of book is:{4}\n Book type is:{5}\n ", Title, Author, ISBN, Price, Availiability, Genre);
        }

        
        
    }
}
