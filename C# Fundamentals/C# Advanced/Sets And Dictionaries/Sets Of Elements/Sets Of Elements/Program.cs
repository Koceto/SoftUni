using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_Of_Elements
{
    public class Program
    {
        public static void Main()
        {
            var length = Console.ReadLine()
                .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < length.First(); i++)
            {
                var input = int.Parse(Console.ReadLine());

                firstSet.Add(input);
            }

            for (int i = 0; i < length.Last(); i++)
            {
                var input = int.Parse(Console.ReadLine());

                if (firstSet.Contains(input))
                {
                    secondSet.Add(input);
                }
            }

            Console.WriteLine(string.Join(" ", secondSet));
        }
    }
}