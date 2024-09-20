using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    internal class Booking
    {

        public int BookingId { get; set; }
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }

        public Booking(int bookingId, Flight flight, Passenger passenger)
        {
            BookingId = bookingId;
            Flight = flight;
            Passenger = passenger;
        }

        public void DisplayBookingDetails()
        {
            Console.WriteLine($"Booking ID: {BookingId}");
            Console.WriteLine($"Passenger: {Passenger.Name} (ID: {Passenger.PassengerId})");
            Flight.DisplayDetails();
        }
    }
}
