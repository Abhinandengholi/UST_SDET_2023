using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HotelRoom<T>
    {


        private int roomNumber;
        private T roomType;
        private bool isbooked;

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public T RoomType { get => roomType; set => roomType = value; }
        public bool Isbooked { get => isbooked; set => isbooked = value; }

        public HotelRoom(int roomNumber, T roomType, bool isbooked)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            Isbooked = isbooked;
        }
    }
}

