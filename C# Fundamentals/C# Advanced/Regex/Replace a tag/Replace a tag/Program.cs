using System;
using System.Text.RegularExpressions;

namespace Replace_a_tag
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = "(<a).+?>";
            var patternInnerds = "(?<=<a).+?(?=>)";
            var patternClosing = "</a>";
            var toBeReplacedClosing = "[/URL]";

            while (text != "end")
            {
                var tag = Regex.Match(text, pattern);
                var innerds = Regex.Match(tag.ToString(), patternInnerds);
                var toBeReplacedOpening = $"[URL{innerds}]";
                text = Regex.Replace(text, pattern, toBeReplacedOpening);
                text = Regex.Replace(text, patternClosing, toBeReplacedClosing);
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
        }
    }
}