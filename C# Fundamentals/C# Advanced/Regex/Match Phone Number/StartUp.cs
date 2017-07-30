using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    public static class StartUp
    {
        public static void Main()
        {
            string pattern = @"\+359(\s|-)\d\1\d{3}\1\d{4}\b";
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                Console.WriteLine(Regex.Match(input, pattern));
            }
        }
    }
}