namespace Swap_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwapCharacter();
        }
        public static void SwapCharacter()
        {
            Console.WriteLine("Enter a string");
            string word = Console.ReadLine();
            if (word.Length == 1)
            {
                Console.WriteLine(word);
            }
            else
            {
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                string swappedWord = lastLetter + word.Substring(1, word.Length - 2) + firstLetter;
                Console.WriteLine("swapped word is : " + swappedWord);
            }
        }
    }
}