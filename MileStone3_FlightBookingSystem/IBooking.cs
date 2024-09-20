using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    internal interface IBooking
    {
        void BookTicket(Flight flight, Passenger passenger);
        void CancelBooking(int bookingId);
        void GetBookingDetails(int bookingId);
    }
}
