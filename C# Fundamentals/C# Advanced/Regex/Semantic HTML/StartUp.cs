using System;
using System.Text.RegularExpressions;

namespace Semantic_HTML
{
    public static class StartUp
    {
        public static void Main()
        {
            string input = String.Empty;
            string idAttrabute = @"(id|class).*?=.*?(""|').*?\2";
            string tagPattern = @"<div.*?[id|class](?:\s|\b)?=(?:\s|\b)?('|"")(?<id>\w+)\1.*?>";
            string closingTagPattern = @"(?<=<!--)\s*\w+\s*(?=-->)";

            while ((input = Console.ReadLine()) != "END")
            {
                var divTag = Regex.Match(input, tagPattern);

                if (divTag.Success)
                {
                    var idReplace = divTag.Groups["id"];
                    var id = Regex.Match(divTag.ToString(), idReplace.ToString());

                    if (id.Success)
                    {
                        string newDivTag = Regex.Replace(divTag.ToString(), idAttrabute, String.Empty);

                        newDivTag = Regex.Replace(newDivTag, @"\s+", " ");
                        newDivTag = Regex.Replace(newDivTag, @"\s+>", ">");
                        newDivTag = Regex.Replace(newDivTag, @"div", id.ToString());

                        Console.WriteLine(newDivTag); ;
                    }
                    else
                    {
                        Console.WriteLine(input);
                    }
                    continue;
                }
                var closingTag = Regex.Match(input, "</div>");
                var replaceClosingTag = Regex.Match(input, closingTagPattern);

                if (closingTag.Success && replaceClosingTag.Success)
                {
                    Console.WriteLine($"</{replaceClosingTag.ToString().Trim()}>");
                }
                else
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}