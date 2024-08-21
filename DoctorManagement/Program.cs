namespace DoctorManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoctorsSystem system = new DoctorsSystem();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n---Doctor Management System---");
                    Console.WriteLine("1. Add Doctor");
                    Console.WriteLine("2. List all doctors");
                    Console.WriteLine("3. Search Doctor by Registration No");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            //Method for adding a new doctor to the system
                            system.AddDoctor();
                            break;
                        case "2":
                            //Method to list all doctors
                            system.ListAllDoctors();
                            
                            break;
                        case "3":
                            //Method to search for a doctor by Registration No
                            system.SearchDoctor();
                            break;
                        case "4":
                            // Exit 
                            Console.WriteLine("--Exiting--");
                            return;
                        default:
                            Console.WriteLine("Choice is Invalid. Please input again");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }
        }
    
    }
}