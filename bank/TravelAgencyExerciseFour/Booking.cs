using System;

namespace TravelAgencyExerciseFour
{
    public class Booking
    {
        public Passenger passenger { get; set; }
        public string TourName { get; set; }
        public int Seats { get; set; }
        public DateTime DateOfTour { get; set; }
    }
}
