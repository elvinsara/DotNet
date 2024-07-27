namespace Employee_Management
{
    class Employee
    {
        /*public int id;
        public string name, gender;
        public double salary;*/
        
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public Employee(int id,string name,double salary,string gender)
        {
           Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
            
        }
       public static int index = 0;
        public static void AddEmployee(Employee[] employee,ref int len)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Id");
            int id  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Salary");
            double salary= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(index + "index");
            if (index<employee.Length)
            {
                //Console.WriteLine(index);
                employee[index] = new Employee(id,name,salary,gender);
                index++;
                //Console.WriteLine(index);

            }

            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine(employee[i].Name);
            }

            Console.WriteLine(len);
            len++;
            Console.WriteLine(len);

        }
        public static void printEmployee()
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Employee[] employee = new Employee[1];
            int len = employee.Length;

            //Employee e = new Employee();
            Employee.AddEmployee(employee,ref  len);
            Employee.AddEmployee(employee,ref len);

        }
    }
}