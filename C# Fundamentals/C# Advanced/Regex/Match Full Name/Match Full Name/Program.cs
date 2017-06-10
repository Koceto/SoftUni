using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                Console.WriteLine(Regex.Match(input, pattern));
            }
        }
    }
}