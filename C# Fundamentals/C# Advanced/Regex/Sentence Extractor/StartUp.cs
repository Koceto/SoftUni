using System;
using System.Text.RegularExpressions;

namespace Sentence_Extractor
{
    public static class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = $"(\\w[^.!?]*)?\\b{word}\\b[^.!?]*[.!?]";
            var matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}