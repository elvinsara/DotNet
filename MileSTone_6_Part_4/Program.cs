using System.Diagnostics;

namespace MileSTone_6_Part_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the numbers to sum
            int num1 = 5;
            int num2 = 10;

            // Path to the Python script
            string scriptPath = @"C:\Users\Administrator\source\repos\Assignments-Training\MileSTone_6_Part_4\sum_script.py"; // Change this path to your script's location

            // Call the Python script and get the output
            try
            {
                // Create a new process for the Python interpreter
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = @"C:\Users\Administrator\AppData\Local\Microsoft\WindowsApps\python.exe", // Ensure python is in your PATH, or provide the full path to python.exe
                    Arguments = $"\"{scriptPath}\" {num1} {num2}", // Pass script path and arguments
                    RedirectStandardOutput = true, // Redirect output so we can read it
                    UseShellExecute = false, // Do not use shell to start the process
                    CreateNoWindow = true // Do not create a window
                };

                // Start the process
                using (Process process = Process.Start(start))
                {
                    // Read the output (result of the sum)
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadLine(); // Read the first line of output
                        Console.WriteLine("The sum is: " + result); // Display the result
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle potential errors
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}