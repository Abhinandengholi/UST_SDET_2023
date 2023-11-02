using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourPackage
    {
        public int PackageID { get; set; }
        public string? Destination { get; set; }
        public string? StartDate { get; set; }
        public int Price { get; set; }

        public static List<TourPackage> bookdpackage = new List<TourPackage>();

        public TourPackage(int packageID, string? destination, string? startDate, int price)
        {
            PackageID = packageID;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public static void PackageBooking(TourPackage packName)
        {
            Thread.Sleep(1000); // simulate the time it takes to register a student
            lock (bookdpackage)
            {
                bookdpackage.Add(packName);
                Console.WriteLine($"{packName.Destination} has booked for the {packName.StartDate} with price:{packName.Price}.");
            }
        }



    }
    
}
