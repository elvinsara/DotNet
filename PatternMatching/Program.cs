using System.Text.RegularExpressions;

namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern1 = "a*b";
            string pattern2 = "a+b";
            Regex reg = new Regex(pattern2);
            Match match = reg.Match("ahhbcd");
            if(match.Success )
            {
                Console.WriteLine("Success");
            }
            else { Console.WriteLine("Fail"); }


        }
    }
}