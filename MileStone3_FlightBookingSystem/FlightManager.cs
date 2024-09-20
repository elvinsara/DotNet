using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    //arrays and list
    internal class FlightManager
    {
        private Flight[] flightArray;  // Fixed-size array for flights
        private List<Flight> flightList;  // Dynamic list for flights

        public FlightManager(int arraySize)
        {
            flightArray = new Flight[arraySize];  // Initialize the array with fixed size
            flightList = new List<Flight>();  // Initialize the dynamic list
        }

        // Adding flights to the array
        public void AddFlightToArray(Flight flight, int index)
        {
            if (index >= 0 && index < flightArray.Length)
            {
                flightArray[index] = flight;
                Console.WriteLine($"Flight added to array at index {index}: {flight.FlightNumber}");
            }
            else
            {
                Console.WriteLine("Invalid array index.");
            }
        }

        // Adding flights to the list
        public void AddFlightToList(Flight flight)
        {
            flightList.Add(flight);
            Console.WriteLine($"Flight added to list: {flight.FlightNumber}");
        }

        // Removing flights from the array (setting null)
        public void RemoveFlightFromArray(int index)
        {
            if (index >= 0 && index < flightArray.Length && flightArray[index] != null)
            {
                Console.WriteLine($"Flight removed from array at index {index}: {flightArray[index].FlightNumber}");
                flightArray[index] = null;  // Set the element to null
            }
            else
            {
                Console.WriteLine("Invalid array index or no flight at the specified index.");
            }
        }

        // Removing flights from the list
        public void RemoveFlightFromList(string flightNumber)
        {
            Flight flightToRemove = flightList.Find(f => f.FlightNumber == flightNumber);
            if (flightToRemove != null)
            {
                flightList.Remove(flightToRemove);
                Console.WriteLine($"Flight removed from list: {flightToRemove.FlightNumber}");
            }
            else
            {
                Console.WriteLine("Flight not found in list.");
            }
        }

        // Searching for flights in the array by flight number
        public void SearchFlightInArray(string flightNumber)
        {
            foreach (Flight flight in flightArray)
            {
                if (flight != null && flight.FlightNumber == flightNumber)
                {
                    Console.WriteLine($"Flight found in array: {flightNumber}");
                    flight.DisplayDetails();
                    return;
                }
            }
            Console.WriteLine($"Flight not found in array: {flightNumber}");
        }

        // Searching for flights in the list by flight number
        public void SearchFlightInList(string flightNumber)
        {
            Flight flight = flightList.Find(f => f.FlightNumber == flightNumber);
            if (flight != null)
            {
                Console.WriteLine($"Flight found in list: {flightNumber}");
                flight.DisplayDetails();
            }
            else
            {
                Console.WriteLine($"Flight not found in list: {flightNumber}");
            }
        }

        // Display all flights in the array
        public void DisplayAllFlightsInArray()
        {
            Console.WriteLine("Flights in array:");
            foreach (Flight flight in flightArray)
            {
                if (flight != null)
                {
                    flight.DisplayDetails();
                }
            }
        }

        // Display all flights in the list
        public void DisplayAllFlightsInList()
        {
            Console.WriteLine("Flights in list:");
            foreach (Flight flight in flightList)
            {
                flight.DisplayDetails();
            }
        }
    }
}
