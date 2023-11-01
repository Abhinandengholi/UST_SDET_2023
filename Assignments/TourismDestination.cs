using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }

        public double Rating { get; set; }
        public static  void Sorting()
        {
            List<TourismDestination> touristdest = new List<TourismDestination>();
            touristdest.Add(new TourismDestination("TajMahal", "BHARATH", 4.7));
            touristdest.Add(new TourismDestination("Charminar", "BHARATH", 4.5));
            touristdest.Add(new TourismDestination("Statue of Liberty", "USA", 3.5));
            touristdest.Add(new TourismDestination("Pyramid", "Egypt", 4.5));
            var result = touristdest.OrderByDescending(s => s.Rating);
            foreach (var s in result)
            {
                Console.WriteLine(s.Name + " " + s.Country + " " + s.Rating);
            }
        }
    }
}
            

