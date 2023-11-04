using Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? location, double rating, int pricePerNight)
        {
            Name = name;
            Location = location;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Location { get; set; }
        public double Rating { get; set; }
        public int PricePerNight { get; set; }

        public static void TouristSpot()
        {
            List<TouristDestination> destin = new List<TouristDestination>();
            destin.Add(new TouristDestination("Beach Paradise", "Tropical Island", 4.7, 150));
            destin.Add(new TouristDestination("Mountain Retreat", "Alpine Village", 4.5, 120));
            destin.Add(new TouristDestination("City Exploration", "Metropolis", 3.5, 200));
            destin.Add(new TouristDestination("Historical Landmarks", "Egypt", 4.5, 400));


           

            IEnumerable<TouristDestination> tds = destin.FindAll(d => d.Rating > 4.3);
            Console.WriteLine("Top-rated Tourist Destinations (Rating > 4.3):");
            foreach (var i in tds)
            {
                Console.WriteLine(i.Name + " " + i.Location + " " + i.Rating);
                
            }




            IEnumerable<TouristDestination> ppn = destin.OrderBy(p => p.PricePerNight);
            Console.WriteLine("Top-rated Tourist Destinations by price");
            foreach (var n in ppn)
            {
                Console.WriteLine(n.Name + " " + n.Location + " " + n.Rating);

            }



            var res = destin.ToLookup(s => s.Location);
            Console.WriteLine("Top-rated Tourist Destinations with location");
            foreach (var s in res)
            {
                Console.WriteLine(s.Key);
                foreach (var x in s)
                {
                    Console.WriteLine(x.Name + " " + x.Location + " " + x.PricePerNight + " " + x.Rating);
                }
            }

        }
    }
}

