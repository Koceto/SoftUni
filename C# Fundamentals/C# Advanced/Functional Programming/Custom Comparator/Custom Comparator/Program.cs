using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Comparator
{
    internal class Program
    {
        private static void Main()
        {
            Func<int[], bool> SpecialArraySorter = numbers =>
            {
                var evenNums = new List<int>();
                var oddNums = new List<int>();

                for (int i = 0; i < numbers.Length; i++)
                {
                    int currentNum = numbers[i];

                    if (currentNum % 2 == 0)
                    {
                        evenNums.Add(currentNum);
                    }
                    else
                    {
                        oddNums.Add(currentNum);
                    }
                }

                Console.Write(string.Join(" ", evenNums.OrderBy(n => n)) + " ");
                Console.Write(string.Join(" ", oddNums.OrderBy(n => n)));

                return true;
            };

            var input = Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SpecialArraySorter(input);
        }
    }
}