using System;
using System.Text.RegularExpressions;

namespace Use_Your_Chains__Buddy
{
    public static class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"<p>(.*?)<\/p>";
            string spacePattern = @"[^a-z0-9]";
            Regex regex = new Regex(pattern);
            Regex spaceReplaceRegex = new Regex(spacePattern);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                var paragraph = spaceReplaceRegex.Replace(match.Groups[1].Value, " ");
                paragraph = Regex.Replace(paragraph, @"\s+", " ");

                foreach (var character in paragraph)
                {
                    if (character >= 'a' && character <= 'm')
                    {
                        Console.Write((char)(character + 13));
                    }
                    else if (character >= 'n' && character <= 'z')
                    {
                        Console.Write((char)(character - 13));
                    }
                    else
                    {
                        Console.Write(character);
                    }
                }
            }
        }
    }
}