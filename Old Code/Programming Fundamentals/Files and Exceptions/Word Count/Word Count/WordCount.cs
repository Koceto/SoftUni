using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    public class WordCount
    {
        public static void Main()
        {
            var filePath = "E:/Users/Коцето/Desktop/Resources/03. Word Count/";
            var words = File.ReadAllText(filePath + "words.txt")
                .Split(' ');
            var text = File.ReadAllText(filePath + "text.txt")
                .ToLower()
                .Split(new[] { ' ', '.', ',', '!', '\r', '\n', '-', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                int currentWordCount = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == word)
                    {
                        currentWordCount++;
                    }
                }

                result[word] = currentWordCount;
            }

            File.WriteAllLines(filePath + "result.txt",
                result
                .OrderByDescending(x => x.Value)
                .Select(y => $"{y.Key} - {y.Value}"));
        }
    }
}
