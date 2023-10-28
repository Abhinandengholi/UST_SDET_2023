using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class PhysicalProduct : Product,IOrderable
    {
        public PhysicalProduct(int productId, string? name, double price, int stockQuantity,double weight,string dimensions) : base(productId, name, price, stockQuantity)
        {
            Weight = weight;
            Dimensions = dimensions;
        }

        public double Weight { get; set; }
        public string Dimensions { get; set; }

        public void PlaceOrder()
        {
            Console.WriteLine($"Placing order for Physical Product: {Name}");
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing payment for Physical Product: {Name}");
        }

        public void DeliverProduct()
        {
            Console.WriteLine($"Delivering Physical Product: {Name}");
            CalculateShippingCosts();
            ProvideTrackingInformation();
        }
        private void CalculateShippingCosts()
        {
            Console.WriteLine($"Calculating shipping price for Physical Product: {Name}");
        }

        private void ProvideTrackingInformation()
        {
            Console.WriteLine($"Providing tracking information for Physical Product: {Name}");
        }
    }
}