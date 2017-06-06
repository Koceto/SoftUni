using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class Program
    {
        public static void Main()
        {
            var contactBook = new SortedDictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "search")
                {
                    break;
                }

                var contactName = input
                    .Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries)
                    .First();
                var contactPhone = input
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .Last();

                if (contactBook.ContainsKey(contactName))
                {
                    contactBook[contactName] = contactPhone;
                }
                else
                {
                    contactBook.Add(contactName, contactPhone);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    break;
                }

                if (contactBook.ContainsKey(input))
                {
                    Console.WriteLine("{0} -> {1}",
                        contactBook.First(c => c.Key == input).Key,
                        contactBook.First(c => c.Key == input).Value);
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
            }
        }
    }
}