using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace projekt_
{

    public class Hotel
    {
        public List<Room> Rooms = new List<Room>();
        public List<Guest> Guests = new List<Guest>();
        public List<Booking> Bookings = new List<Booking>();


        public void SaveAll()
        {
            File.WriteAllText("rooms.txt", JsonConvert.SerializeObject(Rooms));
            File.WriteAllText("guests.txt", JsonConvert.SerializeObject(Guests));
            File.WriteAllText("bookings.txt", JsonConvert.SerializeObject(Bookings));

        }

        public void LoadAll()
        {
            if (File.Exists("rooms.txt"))
            {
                Rooms = JsonConvert.DeserializeObject<List<Room>>
                (File.ReadAllText("rooms.txt"));
            }
            if (File.Exists("guests.txt"))
            {
                Guests = JsonConvert.DeserializeObject<List<Guest>>
                (File.ReadAllText("guests.txt"));
            }
            if (File.Exists("bookings.txt"))
            {
                Bookings = JsonConvert.DeserializeObject<List<Booking>>
                (File.ReadAllText("bookings.txt"));
            }
        }


        public bool IsRoomAvailable(int roomNumber, DateTime from, DateTime to)
        {
            foreach (var b in Bookings)
            {
                if (b.RoomNumber == roomNumber)
                {
                    bool overlap = from < b.CheckOut && to > b.CheckIn;
                    if (overlap) return false;
                }
            }
            return true;
        }

        public int CalculatePrice(Room room, DateTime from, DateTime to)
        {
            int nights = (to - from).Days;
            return nights * room.PricePerNight;
        }

        public List<Room> GetAvailableRooms(
    DateTime from,
    DateTime to,
    int guestCount)
        {
            return Rooms
                .Where(r =>
                    r.IsActive &&
                    r.Capacity >= guestCount &&
                    IsRoomAvailable(r.RoomNumber, from, to))
                .ToList();
        }



    }

}
    


    
