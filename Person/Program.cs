namespace Person
{
    class Person
    {
        public string name;
        public Person(string name)
        {
            this.name = name;
            
        }
        ~Person()
        {
            name = string.Empty;
        }
        public override string ToString()
        {
            return ($"Hello! My name is {name}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];
            for(int i=0; i<person.Length; i++)
            {
                Console.WriteLine("Enter person name");
                person[i] = new Person(Console.ReadLine());

            }
            foreach(var p in person)
            {
                Console.WriteLine(p.ToString());
            }
           
        }
    }
}