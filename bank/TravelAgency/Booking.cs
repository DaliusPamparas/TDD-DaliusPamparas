using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    class Booking
    {
        public Passenger passenger { get; set; }
        public string TourName { get; set; }
        public int Seats { get; set; }
        public DateTime DateOfTour { get; set; }
    }
}
