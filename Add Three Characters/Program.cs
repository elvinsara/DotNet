namespace Add_Three_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddThreeCharacters();
        }
        public static void AddThreeCharacters()
        {
            Console.WriteLine("Enter a string : ");
            string sentence = Console.ReadLine();
            if (sentence.Length < 3)
            {
                Console.WriteLine(sentence + sentence + sentence);
            }
            else
            {
                Console.WriteLine(sentence.Substring(0, 3) + sentence + sentence.Substring(0, 3));
            }
        }
    }
}