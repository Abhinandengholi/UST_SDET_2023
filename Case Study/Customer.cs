using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Customer
    {
        public Customer(int customerID, string? customerName, double contactDetails)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            ContactDetails = contactDetails;

        }
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public double ContactDetails { get; set; }


        public void DisplayCustomerDetails()
        {


            Console.WriteLine("Customer Name is:{0}\n Customer Mobile no:{1}", CustomerName, ContactDetails);
        }
    }
}
