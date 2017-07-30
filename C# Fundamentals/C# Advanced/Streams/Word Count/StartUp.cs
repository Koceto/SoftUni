using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    public static class StartUp
    {
        public static void Main()
        {
            var wordCount = new Dictionary<string, int>();

            using (var wordsReader = new StreamReader(Environment.CurrentDirectory + @"\..\..\words.txt"))
            {
                var words = wordsReader
                    .ReadToEnd()
                    .ToLower()
                    .Split(new[] { " ", "\t", ",", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                using (var reader = new StreamReader(Environment.CurrentDirectory + @"\..\..\text.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        var wordsInLine = line
                            .ToLower()
                            .Split(new[] { ' ', '\t', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var word in wordsInLine)
                        {
                            if (words.Contains(word))
                            {
                                if (wordCount.ContainsKey(word))
                                {
                                    wordCount[word]++;
                                }
                                else
                                {
                                    wordCount.Add(word, 1);
                                }
                            }
                        }
                    }

                    using (var writer = new StreamWriter(Environment.CurrentDirectory + @"\..\..\result.txt"))
                    {
                        foreach (var kvp in wordCount)
                        {
                            writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                        }
                    }
                }
            }
        }
    }
}