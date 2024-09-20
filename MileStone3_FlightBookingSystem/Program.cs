using System.Text.RegularExpressions;

namespace MileStone3_FlightBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a domestic flight
            DomesticFlight domesticFlight = new DomesticFlight("DF123", "New York", "Chicago", 150);
            domesticFlight.DisplayDetails();

            Console.WriteLine();

            // Create an international flight
            InternationalFlight internationalFlight = new InternationalFlight("IF456", "New York", "London", 500);
            internationalFlight.DisplayDetails();


            Passenger passenger1 = new Passenger(1, "John Doe");
            Passenger passenger2 = new Passenger(2, "Jane Smith");

            // Online booking example
            IBooking onlineBooking = new OnlineBooking();
            onlineBooking.BookTicket(domesticFlight, passenger1);
            onlineBooking.GetBookingDetails(1);
            onlineBooking.CancelBooking(1);

            Console.WriteLine();

            // Agency booking example
            IBooking agencyBooking = new AgencyBooking();
            agencyBooking.BookTicket(internationalFlight, passenger2);
            agencyBooking.GetBookingDetails(1);
            agencyBooking.CancelBooking(1);


            FlightManager flightManager = new FlightManager(3);
            DomesticFlight domesticFlight1 = new DomesticFlight("DF123", "New York", "Chicago", 150);
            DomesticFlight domesticFlight2 = new DomesticFlight("DF456", "Los Angeles", "San Francisco", 120);
            InternationalFlight internationalFlight1 = new InternationalFlight("IF789", "New York", "London", 500);
            Console.WriteLine();
            // Adding flights to array
            flightManager.AddFlightToArray(domesticFlight1, 0);
            flightManager.AddFlightToArray(internationalFlight1, 1);
            Console.WriteLine();
            // Adding flights to list
            flightManager.AddFlightToList(domesticFlight2);
            flightManager.AddFlightToList(internationalFlight1);

            Console.WriteLine();

            // Display flights
            flightManager.DisplayAllFlightsInArray();
            flightManager.DisplayAllFlightsInList();

            Console.WriteLine();

            // Search for a flight in the array and list
            flightManager.SearchFlightInArray("DF123");
            flightManager.SearchFlightInList("IF789");

            Console.WriteLine();

            // Removing flights from array and list
            flightManager.RemoveFlightFromArray(0);
            flightManager.RemoveFlightFromList("DF456");

            Console.WriteLine();

            // Display flights again after removal
            flightManager.DisplayAllFlightsInArray();
            flightManager.DisplayAllFlightsInList();





            // Create a list of flights
            List<Flight> flights = new List<Flight>
        {
            new DomesticFlight("DF123", "New York", "Chicago", 150),
            new DomesticFlight("DF456", "Los Angeles", "San Francisco", 120),
            new InternationalFlight("IF789", "New York", "London", 500),
            new InternationalFlight("IF101", "San Francisco", "Denmark", 700),
            new DomesticFlight("DF111", "Miami", "New York", 90)
        };

            // 1. Filter flights by destination
            var flightsToNewYork = from flight in flights
                                   where flight.Destination == "New York"
                                   select flight;

            Console.WriteLine("====Flights to New York:====");
            foreach (var flight in flightsToNewYork)
            {
                flight.DisplayDetails();
            }

            Console.WriteLine();


            // 2. Sort flights by fare
            var flightsSortedByFare = from flight in flights
                                      orderby flight.CalculateFare() ascending
                                      select flight;

            Console.WriteLine("===Flights sorted by fare:===");
            foreach (var flight in flightsSortedByFare)
            {
                flight.DisplayDetails();
            }

            Console.WriteLine();

            // 3. Group flights by category (Domestic vs. International)
            var groupedFlights = from flight in flights
                                 group flight by flight.GetType().Name into flightGroup
                                 select flightGroup;

            Console.WriteLine("====Flights grouped by category:===");
            foreach (var group in groupedFlights)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var flight in group)
                {
                    flight.DisplayDetails();
                }
            }

            Console.WriteLine();
            //filter with traditional loop
            List<Flight> flightsToLondon = new List<Flight>();
            foreach (Flight flight in flights)
            {
                if (flight.Destination == "London")
                {
                    flightsToLondon.Add(flight);
                }
            }


            // Read flight data from CSV file
            string filePath = "flights.csv";
            string writeFilePath = "flightswrite.csv";
            ReadFlightsFromCSV(filePath, flights);

            // Display the flights read from the file
            Console.WriteLine("Flights loaded from file:");
            foreach (Flight flight in flights)
            {
                flight.DisplayDetails();
            }
            // Write updated flight data back to CSV file
            WriteFlightsToCSV(filePath, flights);

            string flightNumber = "FL1234";
            string email = "test.user@example.com";
            string phoneNumber = "+1-123-456-7890";

            // Validate flight number
            if (ValidateFlightNumber(flightNumber))
            {
                Console.WriteLine("Flight number is valid.");
            }
            else
            {
                Console.WriteLine("Flight number is invalid.");
            }

            // Validate email
            if (ValidateEmail(email))
            {
                Console.WriteLine("Email address is valid.");
            }
            else
            {
                Console.WriteLine("Email address is invalid.");
            }

            // Validate phone number
            if (ValidatePhoneNumber(phoneNumber))
            {
                Console.WriteLine("Phone number is valid.");
            }
            else
            {
                Console.WriteLine("Phone number is invalid.");
            }


            // 1. Filtering flights based on destination
            var flightToDenmark = flights.Where(f => f.Destination == "Denmark");

            Console.WriteLine("Flights to Denmark:");
            foreach (var flight in flightToDenmark)
            {
                Console.WriteLine($"-Flight Number-: {flight.FlightNumber}, Destination: {flight.Destination}");
            }

            // 2. Selecting specific properties: FlightNumber and Fare
            var selectedProperties = flights.Select(f => new
            {
                FlightNumber = f.FlightNumber,
                BaseFare = f.BaseFare
                
            });

            Console.WriteLine("\nSelected Flight Properties (FlightNumber):");
            foreach (var flight in selectedProperties)
            {
                Console.WriteLine($"Flight Number: {flight.FlightNumber},Base fare :{flight.BaseFare}");
            }

            // 3. Projecting flight details into a new format
            var flightProjections = flights.Select(f => new
            {
                Description = $"Flight {f.FlightNumber} from {f.Departure} to {f.Destination}",
                TotalFare = f.BaseFare
            });

            Console.WriteLine("\nProjected Flight Details:");
            foreach (var flight in flightProjections)
            {
                Console.WriteLine($"{flight.Description}, Total Fare: {flight.TotalFare}");
            }


        }

        // Method to read flight data from a CSV file
        public static void ReadFlightsFromCSV(string filePath, List<Flight> flights)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length != 5) continue;

                        string flightNumber = parts[0];
                        string origin = parts[1];
                        string destination = parts[2];
                        double baseFare = double.Parse(parts[3]);
                        string type = parts[4];

                        Flight flight = null;
                        if (type == "Domestic")
                        {
                            flight = new DomesticFlight(flightNumber, origin, destination, baseFare);
                        }
                        else if (type == "International")
                        {
                            flight = new InternationalFlight(flightNumber, origin, destination, baseFare);
                        }

                        if (flight != null)
                        {
                            flights.Add(flight);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }

        // Method to write flight data to a CSV file
        public static void WriteFlightsToCSV(string filePath, List<Flight> flights)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Flight flight in flights)
                    {
                        string type = flight is DomesticFlight ? "Domestic" : "International";
                        string line = $"{flight.FlightNumber},{flight.Destination},{flight.BaseFare},{type}";
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("Flight data successfully written to the file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }


        }
        // Method to validate flight number (e.g., FL1234)
        public static bool ValidateFlightNumber(string flightNumber)
        {
            string pattern = @"^[A-Z]{2}\d{3,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(flightNumber);
        }


        // Method to validate email address
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        // Method to validate phone number
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^\+?[0-9]{1,3}[-.\s]?\(?\d{1,3}\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }

    }
}

