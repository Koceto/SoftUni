using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var dict = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                var command = input[0];
                if (command.ToLower() == "end")
                {
                    return;
                }
                else if (command.ToLower() == "a")
                {
                    dict[input[1]] = input[2];
                }
                else if (command.ToLower() == "s")
                {
                    var name = input[1];
                    if (dict.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {dict[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}
