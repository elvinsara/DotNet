namespace Add_Characters_to_First_And_Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddCharacter();
        }
        public static void AddCharacter()
        {
            Console.WriteLine("Enter a string");
            string sentence = Console.ReadLine();
            char firstCharacter = sentence[0];
            Console.WriteLine(firstCharacter + sentence + firstCharacter);
        }
    }
}