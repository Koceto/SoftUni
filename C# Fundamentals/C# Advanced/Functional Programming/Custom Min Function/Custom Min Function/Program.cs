using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    internal class Program
    {
        private static void Main()
        {
            Func<List<int>, int> Min = numbers =>
            {
                int minNum = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < minNum)
                    {
                        minNum = number;
                    }
                }

                return minNum;
            };

            var input = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(Min(input));
        }
    }
}