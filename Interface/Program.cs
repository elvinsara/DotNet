namespace Interface
{

    public interface IVehicle {
        void Drive();
        bool Refuel(int fuel);
    }

    public class Car : IVehicle {

        public int gas;
        public Car(int gas)
        {
            this.gas = gas; 
        }
        public void Drive() {
            if (gas > 0)
            {
                Console.WriteLine("Driving");
                gas--;
            }
            else
            {
                Console.WriteLine("Not enough fuel");
            }
        } 
        public bool Refuel(int fuel) {
            gas += fuel;
            return true;
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(0);
            int fuel =Convert.ToInt32(Console.ReadLine());
            c.Refuel(fuel);
            c.Drive();

            
        }
    }
}