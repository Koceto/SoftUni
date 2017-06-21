using System;
using System.Linq;

namespace Predicate_Party_
{
    internal class Program
    {
        private static void Main()
        {
            Func<string, string, string, bool> NameChecker = (name, condition, action) =>
            {
                var n = 0;

                if (name.IndexOf(condition) == 0 && action == "StartsWith")
                {
                    return true;
                }
                if (name.IndexOf(condition) == name.Length - condition.Length && action == "EndsWith")
                {
                    return true;
                }
                if (int.TryParse(condition, out n) && action == "Length")
                {
                    if (name.Length == n)
                    {
                        return true;
                    }
                }

                return false;
            };

            var guests = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] temp = command.Split(' ');
                string action = temp[0];
                string condition = temp[2];
                string parameter = temp[1];

                if (action == "Remove")
                {
                    guests = guests
                            .Where(n => !NameChecker(n, condition, parameter))
                            .ToList();
                }
                else if (action == "Double")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        var guest = guests[i];

                        if (NameChecker(guest, condition, parameter))
                        {
                            var insertIndex = guests.IndexOf(guest);
                            guests.Insert(insertIndex, guest);
                            i++;
                        }
                    }
                }
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine("{0} are going to the party!", string.Join(", ", guests));
            }
        }
    }
}