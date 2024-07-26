namespace Employee
{
    public class Employee
    {
        public int id;
        public string name,gender;
        public double salary;
       
        public void GetDetails()
        {
            Console.WriteLine("Enter ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Gender : ");
            gender = Console.ReadLine();
        }
        public void PrintDetails()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("ID : "+id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Salary : "+salary);
            Console.WriteLine("Gender : "+gender);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
           employee.GetDetails();
            employee.PrintDetails();
            
        }
    }
}