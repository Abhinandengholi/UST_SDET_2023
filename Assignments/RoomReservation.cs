using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
        private static List<HotelRoom<T>> resrv = new();
        public static void RoomBook(int roomno, ref T roomtype)
        {
            HotelRoom<T> rb = new(roomno, roomtype, true);
            resrv.Add(rb);
            Console.WriteLine("Room Booked,Room number: {0},Room type:{1}", rb.RoomNumber, rb.RoomType);
        }
        public static void RoomCancel(int roomno)
        {
            foreach (var i in resrv)
            {
                if (i.RoomNumber == roomno)
                {
                    i.Isbooked = false;
                    Console.WriteLine("Booking Cancelled");
                    break;
                }
            }
            
        }

    }
}
