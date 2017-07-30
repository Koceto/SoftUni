using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extract_Hyperlinks
{
    public static class StartUp
    {
        public static void Main()
        {
            var input = string.Empty;
            var links = new List<string>();
            var builder = new StringBuilder();

            while ((input = Console.ReadLine()) != "END")
            {
                builder.Append(input);
            }
            var text = builder.ToString();

            while (true)
            {
                var firstIndex = text.IndexOf("<a");

                if (firstIndex == -1)
                {
                    break;
                }

                text = text.Remove(0, firstIndex + 2);
                var secondIndex = text.IndexOf(">");

                if (secondIndex == -1)
                {
                    secondIndex = Math.Max(text.Length - 1, 0);
                }

                var currTag = text.Substring(0, secondIndex);
                currTag = currTag.Replace("=", String.Empty);

                currTag = currTag
                    .Trim()
                    .Split(new[] { "href" }, StringSplitOptions.RemoveEmptyEntries)
                    .Last()
                    .Trim();
                var linkEndIndex = currTag.IndexOf(" ");

                if (linkEndIndex == -1)
                {
                    linkEndIndex = currTag.Length - 1;
                }

                var currLink = currTag.Trim().Substring(0, linkEndIndex);

                if (currLink.Length != 0)
                {
                    links.Add(currLink);
                }
            }

            foreach (var link in links)
            {
                Console.WriteLine(link.Trim('\"', ' ', '\'', '\t'));
            }
        }
    }
}