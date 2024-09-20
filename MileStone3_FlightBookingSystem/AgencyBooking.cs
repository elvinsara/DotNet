using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    internal class AgencyBooking :IBooking
    {

        private Dictionary<int, Booking> bookings = new Dictionary<int, Booking>();
        private int nextBookingId = 1;

        public void BookTicket(Flight flight, Passenger passenger)
        {
            Booking newBooking = new Booking(nextBookingId++, flight, passenger);
            bookings.Add(newBooking.BookingId, newBooking);
            Console.WriteLine($"Agency booking completed. Booking ID: {newBooking.BookingId}");
        }

        public void CancelBooking(int bookingId)
        {
            if (bookings.ContainsKey(bookingId))
            {
                bookings.Remove(bookingId);
                Console.WriteLine($"Agency booking {bookingId} canceled.");
            }
            else
            {
                Console.WriteLine($"Booking {bookingId} not found.");
            }
        }

        public void GetBookingDetails(int bookingId)
        {
            if (bookings.ContainsKey(bookingId))
            {
                bookings[bookingId].DisplayBookingDetails();
            }
            else
            {
                Console.WriteLine($"Booking {bookingId} not found.");
            }
        }
    }
}
