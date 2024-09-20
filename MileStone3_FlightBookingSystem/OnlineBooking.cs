using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    internal class OnlineBooking : IBooking
    {
        private List<Booking> bookings = new List<Booking>();
        private int nextBookingId = 1;

        public void BookTicket(Flight flight, Passenger passenger)
        {
            Booking newBooking = new Booking(nextBookingId++, flight, passenger);
            bookings.Add(newBooking);
            Console.WriteLine($"Online booking completed. Booking ID: {newBooking.BookingId}");
        }

        public void CancelBooking(int bookingId)
        {
            Booking booking = bookings.Find(b => b.BookingId == bookingId);
            if (booking != null)
            {
                bookings.Remove(booking);
                Console.WriteLine($"Booking {bookingId} canceled successfully.");
            }
            else
            {
                Console.WriteLine($"Booking {bookingId} not found.");
            }
        }

        public void GetBookingDetails(int bookingId)
        {
            Booking booking = bookings.Find(b => b.BookingId == bookingId);
            if (booking != null)
            {
                booking.DisplayBookingDetails();
            }
            else
            {
                Console.WriteLine($"Booking {bookingId} not found.");
            }
        }
    }
}
