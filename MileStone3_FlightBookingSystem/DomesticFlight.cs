using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    internal class DomesticFlight :Flight
    {
        public double TaxPercentage { get; set; } = 0.1;  // 10% tax for domestic flights

        public DomesticFlight(string flightNumber, string departure, string destination, double baseFare)
        {
            FlightNumber = flightNumber;
            Departure = departure;
            Destination = destination;
            BaseFare = baseFare;
        }

        // Calculate the fare with domestic tax
        public override double CalculateFare()
        {
            return BaseFare + (BaseFare * TaxPercentage);
        }

        // Display the flight details
        public override void DisplayDetails()
        {
            Console.WriteLine($"Domestic Flight - {FlightNumber}");
            Console.WriteLine($"From: {Departure}, To: {Destination}");
            Console.WriteLine($"Base Fare: {BaseFare}, Total Fare: {CalculateFare()}");
        }
    }
}
