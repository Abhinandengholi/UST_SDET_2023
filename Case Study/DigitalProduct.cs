using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class DigitalProduct:Product,IOrderable
    {
        public DigitalProduct(int productId, string? name, double price, int stockQuantity,string? downloadLink,string? fileFormat) : base(productId,name, price, stockQuantity)
        {
            DownloadLink = downloadLink;
            FileFormat = fileFormat;
        }
    

        public  string? DownloadLink { get; set; }
        public string? FileFormat { get; set; }

        public void PlaceOrder()
        {
            Console.WriteLine($"Placing order for Digital Product: {0}",Name);
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing payment for Digital Product: {0}",Name);
        }

        public void DeliverProduct()
        {
            Console.WriteLine($"Delivering Digital Product: {0}",Name);
            ProvideDownloadLink();
        }
        private void ProvideDownloadLink()
        {
            
            Console.WriteLine($"Providing download link for Digital Product: {0}",Name);
            Console.WriteLine($"Download Link: {DownloadLink}");
        }
    }
}