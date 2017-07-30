using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    public class LargestNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
