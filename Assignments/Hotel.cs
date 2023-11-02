using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel : TourismDestination
    {
        public Hotel(string? name, string? country, double rating, string? hotelName, int? availableRoom) : base(name, country, rating)
        {

        
            HotelName = hotelName;
            AvailableRoom = availableRoom;
        }

        public string? HotelName { get; set; }
        public int? AvailableRoom { get; set; }

        public async Task HotelbookingAsync(int roomsReq)
        {
            if (roomsReq <= AvailableRoom)
            {
                // Simulate processing time
                await Task.Delay(1000);

                // Reduce the number of available rooms
                AvailableRoom -= roomsReq;
                Console.WriteLine($"{roomsReq} rooms are booked in {HotelName}");
                

                
            }
            else
            {
                Console.WriteLine("Sorry,Rooms are not availaible");
            }
        }
    }
    }
    

