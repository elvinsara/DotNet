using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagement
{
    internal class DoctorsSystem
    {
        // create a dictionary to store doctor information
        private readonly Dictionary<string, Doctors> doctors = new Dictionary<string, Doctors>();

        public void AddDoctor()
        {
            try
            {
                string registerNumber;
                
                do
                {
                    Console.Write("Enter a 7 digit Registration number: ");
                    registerNumber = Console.ReadLine();

                    // Check if Registration Number is valid
                    if (!Validation.ValidateRegistrationNo(registerNumber))
                    {
                        Console.WriteLine("Invalid Registration Number. Must contain 7 digits");
                        continue;
                    }

                    // Check if  Registration Number exists in the dictionary
                    if (doctors.ContainsKey(registerNumber))
                    {
                        Console.WriteLine("Register number already exists.");
                        registerNumber = null; 
                    }
                } while (string.IsNullOrEmpty(registerNumber));

                string name;
                
                do
                {
                    Console.Write("Enter Doctor Name: ");
                    name = Console.ReadLine();
                    if (!Validation.ValidateName(name))
                    {
                        Console.WriteLine("Invalid Doctor Name.");
                    }
                } while (!Validation.ValidateName(name));

                string city;
                
                do
                {
                    Console.Write("Enter City: ");
                    city = Console.ReadLine();
                    
                    break;
                } while (true);

                string specialization;
                
                do
                {
                    Console.Write("Enter Area of Specialization: ");
                    specialization = Console.ReadLine();
                    if (!Validation.ValidateName(specialization))
                    {
                        Console.WriteLine("Invalid Area of Specialization. It should contain only alphabets.");
                    }
                } while (!Validation.ValidateName(specialization));

                string address;

                Console.Write("Enter Clinic Address: ");
                address = Console.ReadLine();


                string timings;
                
                do
                {
                    Console.Write("Enter Clinic Timings: ");
                    timings = Console.ReadLine();
                    if (!Validation.ValidateClinicTimings(timings))
                    {
                        Console.WriteLine("Invalid Clinic Timings. It should not be empty.");
                    }
                } while (!Validation.ValidateClinicTimings(timings));

                string contactNo;
               
                do
                {
                    Console.Write("Enter Contact No (10 digits): ");
                    contactNo = Console.ReadLine();
                    if (!Validation.ValidateContactNo(contactNo))
                    {
                        Console.WriteLine("Invalid Contact No. It should be 10 digits.");
                    }
                } while (!Validation.ValidateContactNo(contactNo));

                // Create a new Doctor object 
                Doctors doctor = new Doctors(registerNumber, name, city, specialization, address, timings, contactNo);
                doctors[registerNumber] = doctor;
                Console.WriteLine("Doctor added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }

        public void SearchDoctor()
        {
            try
            {
                Console.Write("Enter Registration No to search: ");
                string regNo = Console.ReadLine();

                if (doctors.TryGetValue(regNo, out Doctors doctor))
                {
                    Console.WriteLine($"Registration No: {doctor.RegistrationNo}");
                    Console.WriteLine($"Name: {doctor.Name}");
                    Console.WriteLine($"City: {doctor.City}");
                    Console.WriteLine($"Specialization: {doctor.Specialization}");
                    Console.WriteLine($"Address: {doctor.Address}");
                    Console.WriteLine($"Timings: {doctor.Timings}");
                    Console.WriteLine($"Contact No: {doctor.ContactNo}");
                }
                else
                {
                    Console.WriteLine("Doctor not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void ListAllDoctors()
        {
            foreach(KeyValuePair<String,Doctors> doctor in  doctors)
            {
                Doctors person = doctor.Value;
                Console.WriteLine("-----------------");
                Console.WriteLine($"Registration No: {person.RegistrationNo}");
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"City: {person.City}");
                Console.WriteLine($"Specialization: {person.Specialization}");
                Console.WriteLine($"Address: {person.Address}");
                Console.WriteLine($"Timings: {person.Timings}");
                Console.WriteLine($"Contact No: {person.ContactNo}");
            }
        }
    }
}
