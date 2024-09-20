using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    internal class InternationalFlight : Flight
    {
        public double TaxPercentage { get; set; } = 0.2;  // 20% tax for international flights
        public double InternationalFee { get; set; } = 50; // Flat international fee

        public InternationalFlight(string flightNumber, string departure, string destination, double baseFare)
        {
            FlightNumber = flightNumber;
            Departure = departure;
            Destination = destination;
            BaseFare = baseFare;
        }

        // Calculate the fare with international tax and fee
        public override double CalculateFare()
        {
            return BaseFare + (BaseFare * TaxPercentage) + InternationalFee;
        }

        // Display the flight details
        public override void DisplayDetails()
        {
            Console.WriteLine($"International Flight - {FlightNumber}");
            Console.WriteLine($"From: {Departure}, To: {Destination}");
            Console.WriteLine($"Base Fare: {BaseFare}, Total Fare: {CalculateFare()}");
        }
    }
}
