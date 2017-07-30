using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Of_Predicates
{
    public static class StartUp
    {
        public static void Main()
        {
            Func<int, int[], int[]> Divisibles = (range, numbers) =>
            {
                var result = new List<int>();

                for (int i = 1; i <= range; i++)
                {
                    var isDivisible = true;

                    foreach (var number in numbers)
                    {
                        if (i % number != 0)
                        {
                            isDivisible = false;
                        }
                    }

                    if (isDivisible)
                    {
                        result.Add(i);
                    }
                }

                return result.ToArray();
            };

            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(string.Join(" ", Divisibles(n, dividers)));
        }
    }
}