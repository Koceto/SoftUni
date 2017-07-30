using System;
using System.Collections.Generic;
using System.Linq;

namespace Min__Max__Sum__Average
{
    public class MinMaxSumAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average());
        }
    }
}
