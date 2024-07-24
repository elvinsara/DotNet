namespace Gross_Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateEmployeeSalary();
        }
        public static void CalculateEmployeeSalary()
        {
            Console.WriteLine("Enter gross salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            double grossSalary;
            if (salary <= 10000)
            {
                grossSalary = salary + salary * 0.2 + salary * 0.8;
            }
            else if (salary <= 20000)
            {
                grossSalary = salary + salary * 0.25 + salary * 0.9;
            }
            else
            {
                grossSalary = salary + salary * 0.3 + salary * 0.95;
            }
            Console.WriteLine("Gross salary is : ", grossSalary);
        }
    }
}