using System;
using System.Text.RegularExpressions;

namespace Extract_Email
{
    public static class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            Regex regex = new Regex(pattern);

            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match);
            }
        }
    }
}