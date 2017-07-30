using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Extract_Hyperlinks
{
    public static class StartUp
    {
        public static void Main()
        {
            string input = String.Empty;
            var stringBuilder = new StringBuilder();
            string tagPattern = @"<a.+?>";
            string linkPattern = @"(?<=href)(?:\b|\s)=(?:(?:\s?('|"").+?\1)|.+?(?=>| ))";
            string innardsPattern = @"(?<=(""|')).+(?=\1)";
            string altPattern = @"(?<==).+?(?= |$)";
            Regex tagRegex = new Regex(tagPattern);
            Regex linkRegex = new Regex(linkPattern);
            Regex innardRegex = new Regex(innardsPattern);
            Regex altRegex = new Regex(altPattern);

            while ((input = Console.ReadLine()) != "END")
            {
                stringBuilder.Append(input);
            }

            var matches = tagRegex.Matches(stringBuilder.ToString());

            foreach (Match match in matches)
            {
                var link = linkRegex.Match(match.ToString());

                if (link.Success)
                {
                    var innards = innardRegex.Match(link.ToString());

                    if (innards.Success)
                    {
                        Console.WriteLine(innards);
                    }
                    else
                    {
                        Console.WriteLine(altRegex.Match(link.ToString()));
                    }
                }
            }
        }
    }
}