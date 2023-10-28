using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Customers
    {
        public Customers(int customerId, string? name, string? email)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
        }

        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public List<Order>? PlacedOrders { get; set; }

        public void PlaceOrder(Order order)
        {
            
            {
                if (PlacedOrders == null)
                    PlacedOrders = new List<Order>();

                PlacedOrders.Add(order);
                Console.WriteLine($"Order placed successfully for : {order.ProductID}");
            }
        }

        public void ProcessPayment()
        {
            if (PlacedOrders != null && PlacedOrders.Count > 0)
            {
                foreach (var order in PlacedOrders)
                {
                    if (order.Status == "Pending")
                    {
                        // Process payment for pending orders
                        Console.WriteLine($"Processing payment for order ID: {order.OrderID}");
                        order.Status = "Payment completed";
                    }
                }
            }
        }

        public void ViewOrderHistory()
        {
            if (PlacedOrders != null && PlacedOrders.Count > 0)
            {
                Console.WriteLine($"Order History for Customer {Name}:");
                foreach (var order in PlacedOrders)
                {
                    Console.WriteLine($"Order ID: {order.OrderID}, Product ID: {order.ProductID}, Status: {order.Status}");
                }
            }
            else
            {
                Console.WriteLine("No order history for this customer.");
            }
        }

        public void ContactSupport()
        {
            Console.WriteLine("Contacting customer support...");
        }
    }
}
