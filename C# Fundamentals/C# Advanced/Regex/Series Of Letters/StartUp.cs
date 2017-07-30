using System;
using System.Text.RegularExpressions;

namespace Series_Of_Letters
{
    public static class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim();
            string pattern = @"(\w)\1+";
            var match = Regex.Match(input, pattern);

            while (match.Success)
            {
                var toBeRaplaced = match.ToString()[0];

                input = Regex.Replace(input, match.ToString(), toBeRaplaced.ToString());
                match = Regex.Match(input, pattern);
            }

            Console.WriteLine(input);
        }
    }
}