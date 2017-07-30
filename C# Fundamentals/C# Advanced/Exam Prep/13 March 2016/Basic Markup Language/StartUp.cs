using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Basic_Markup_Language
{
    public static class StartUp
    {
        public const string pattern = @"^<\s*([a-z]+)\s+(?:(?:content\s*=\s*""(.+)""\s*\/\s*>$)|value\s*=\s*""(\d+)""\s*content\s*=\s*""(.+)""\s*\/\s*>$)";
        public const string EndCommand = "<stop/>";

        public static void Main()
        {
            string input;
            int count = 1;
            Regex regex = new Regex(pattern);

            while ((input = Console.ReadLine().Trim()) != EndCommand)
            {
                var match = regex.Match(input);
                string command = match.Groups[1].ToString();

                if (command == "inverse")
                {
                    char[] content = match.Groups[2].ToString().ToCharArray();

                    Console.Write($"{count}. ");
                    count++;

                    foreach (var letter in content)
                    {
                        if (Char.IsLower(letter))
                        {
                            Console.Write(Char.ToUpper(letter));
                        }
                        else
                        {
                            Console.Write(Char.ToLower(letter));
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "reverse")
                {
                    char[] content = match.Groups[2].ToString().ToCharArray();

                    Console.WriteLine("{0}. {1}", count, string.Join("", content.Reverse()));
                    count++;
                }
                else if (command == "repeat")
                {
                    string content = match.Groups[4].ToString();
                    int value = int.Parse(match.Groups[3].ToString());

                    for (int i = 0; i < value; i++)
                    {
                        Console.WriteLine($"{count}. {content}");
                        count++;
                    }
                }
            }
        }
    }
}