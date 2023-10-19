using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product
    {
        private string? prouductName;
        private double price;
          private int quantity;

        public Product(string? prouductName, double price, int quantity)
        {
            ProuductName = prouductName;
            Price = price;
            Quantity = quantity;

        }

        public string? ProuductName { get => prouductName; set => prouductName = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public  double SetPrice(double newPrice)
        {
            price = newPrice;
            return price;
        }
        public double ProductValue()
        {
            double totalvalue = price * quantity;
            Console.WriteLine("Totalvalue:" + totalvalue);
            return totalvalue;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Product Name:" + ProuductName);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Quantity:" + quantity);
        }
    }
}
