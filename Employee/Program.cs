namespace Employee
{
    class Employee
    {
        public int Id;
        public string EmployeeName, Gender;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            Employee[] employeeArray = new Employee[3];
            int choice, CurrentIndex = 0;
            bool exit = false;

            while (!exit)
            {

                Console.WriteLine("\n1.Add Employee\n2.Update Employee\n3.Delete Employee\n4.List Employee\n5.Exit\n");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (CurrentIndex >= employeeArray.Length)
                        {
                            Console.WriteLine("Cannot add employee");
                            break;
                        }
                        else
                        {
                            Employee emp = new Employee();
                            Console.WriteLine("Enter Employee ID : \n");
                            emp.Id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Employee Name : ");
                            emp.EmployeeName = Console.ReadLine();

                            Console.Write("Enter Employee Gender : ");
                            emp.Gender = Console.ReadLine();

                            employeeArray[CurrentIndex] = emp;
                            Console.WriteLine("Employee added successfully");

                            CurrentIndex++;

                            break;
                        }

                    case 2:
                        Console.Write("\nEnter the employee id to update : ");
                        int inputId = Convert.ToInt32(Console.ReadLine());
                        bool updateIdFound = false;

                        for (int i = 0; i < CurrentIndex; i++)
                        {
                            if (employeeArray[i].Id == inputId)
                            {
                                updateIdFound = true;
                                Console.Write("Enter New Employee Name : ");
                                employeeArray[i].EmployeeName = Console.ReadLine();

                                Console.Write("Enter new Employee Gender : ");
                                employeeArray[i].Gender = Console.ReadLine();
                                Console.WriteLine("Employee Updated successfully");
                            }
                        }
                        if (!updateIdFound)
                        {
                            Console.WriteLine("\nId not found");
                        }
                        break;


                    case 3:
                        Console.Write("\nEnter id of employee to delete : ");
                        int deleteInputId = Convert.ToInt32(Console.ReadLine());
                        bool idFound = false;
                        for (int i = 0; i <= CurrentIndex; i++)
                        {
                            if (employeeArray[i].Id == deleteInputId)
                            {
                                idFound = true;
                                for (int j = i; j < CurrentIndex; j++)
                                {
                                    employeeArray[j] = employeeArray[j + 1];
                                }
                                employeeArray[CurrentIndex - 1] = null;
                                CurrentIndex--;
                                Console.WriteLine("\nEmployee deleted successfully");

                            }
                        }
                        if (!idFound)
                        {
                            Console.WriteLine("\nId not found");
                        }
                        break;

                    case 4:
                        if (CurrentIndex == 0)
                        {
                            Console.WriteLine("\nNo Employee details found");
                            break;
                        }
                        Console.WriteLine("\nAll employee details are :");

                        for (int i = 0; i < CurrentIndex; i++)
                        {
                            Console.Write("\nEmployee id : " + employeeArray[i].Id);
                            Console.Write("\nEmployee Name : " + employeeArray[i].EmployeeName);
                            Console.Write("\nEmployee Gender : " + employeeArray[i].Gender + "\n");

                        }
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice");
                        break;


                }

            }
        }

    }
    }
}