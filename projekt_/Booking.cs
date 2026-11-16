using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_
{
    
        public class Booking
        {
            public int Id { get; set; }
            public int GuestId { get; set; }
            public int RoomNumber { get; set; }
            public DateTime CheckIn { get; set; }
            public DateTime CheckOut { get; set; }
            public int GuestCount { get; set; }
            public string Status { get; set; }
            public int TotalPrice { get; set; }
        }

    
}
