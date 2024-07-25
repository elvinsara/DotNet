namespace Pallindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            int inputStringLength = inputString.Length;
          
            bool notPallindrome = false;

            if(inputStringLength !=1) {
                for (int i = 0; i < inputString.Length; i++)
                {

                    if (inputString[i] != inputString[inputStringLength - 1])
                    {
                        //counter = counter + 1;
                        notPallindrome = true;
                        break;


                    }


                    inputStringLength--;

                }
            }
           if (notPallindrome)
            {
                Console.WriteLine("Not a pallindrome");
            }
           else { Console.WriteLine("Pallindrome"); }
            
            
        }
    }
}