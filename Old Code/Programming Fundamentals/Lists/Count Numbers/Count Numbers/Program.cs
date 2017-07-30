using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numbersCount = new int[numbers.Max() + 1];

            foreach (var digit in numbers)
            {
                numbersCount[digit]++;
            }

            for (int i = 0; i < numbersCount.Length; i++)
            {
                if (numbersCount[i] > 0)
                {
                    Console.WriteLine($"{i} -> {numbersCount[i]}");
                }
            }
        }
    }
}
