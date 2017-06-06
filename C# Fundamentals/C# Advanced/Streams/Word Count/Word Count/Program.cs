using System.Linq;
using System.Linq.Expressions;

namespace Word_Count
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var wordCount = new Dictionary<string, int>();

            using (var wordsReader = new StreamReader(Environment.CurrentDirectory + @"\..\..\words.txt"))
            {
                var words = wordsReader
                    .ReadToEnd()
                    .ToLower()
                    .Split(new string[] { " ", "\t", ",", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

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
