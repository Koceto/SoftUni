using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderBy(n => n);

            var numbersAndCount = new SortedDictionary<double, int>();

            foreach (var digit in numbers)
            {
                if (!numbersAndCount.ContainsKey(digit))
                {
                    numbersAndCount[digit] = 0;
                }
                numbersAndCount[digit]++;
            }

            foreach (var item in numbersAndCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
