using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(string.Join("", x.Reverse())))
                .Sum();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
