namespace Electricity_Unit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateUnit();
        }
        public static void CalculateUnit()
        {
            Console.WriteLine("Enter electricity unit");
            int unit = Convert.ToInt32(Console.ReadLine());
            double price = 1;
            if (unit <= 50)
            {
                price = unit * 0.5;
            }
            else if (unit > 50 && unit <= 150)
            {
                price = unit * 0.75;
            }
            else if (unit > 150 && unit <= 250)
            {
                price = unit * 1.20;
            }
            else
            {
                price = unit + (unit * 0.2);
            }
            Console.WriteLine("Total price : " + price);
        }
    }
}