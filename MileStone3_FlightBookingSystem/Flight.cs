using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    abstract class Flight
    {
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public double BaseFare { get; set; }



        // Abstract methods to be implemented by derived classes
        public abstract double CalculateFare();
        public abstract void DisplayDetails();
    }
}
