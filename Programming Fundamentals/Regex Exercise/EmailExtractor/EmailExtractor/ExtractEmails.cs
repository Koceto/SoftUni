namespace EmailExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\s\b([a-z](?:_?[a-z0-9\-\.]+@[a-z\-]+\.[a-z]+([\.a-z]+)?))\b");
            var result = regex.Matches(text);

            foreach (Match match in result)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}
