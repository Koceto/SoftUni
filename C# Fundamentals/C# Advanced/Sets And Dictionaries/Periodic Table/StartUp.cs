using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    public static class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in input)
                {
                    elements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}