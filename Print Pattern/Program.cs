namespace Print_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pattern 1
            Console.WriteLine("Pattern -1");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //pattern 2

            Console.WriteLine("Pattern -2");

            int num = 8;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == 0 || i == num - 1 || j == 0 || j == num - 1 || i == j || i + j == num - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            //pattern 3
            Console.WriteLine("Pattern -3");


            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (j >= i || i == 9 - j || 9 - j <= i)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("\n");
            }

        }
    }
}