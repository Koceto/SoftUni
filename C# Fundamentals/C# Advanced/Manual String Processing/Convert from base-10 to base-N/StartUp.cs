using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Convert_from_base_10_to_base_N
{
    public static class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();
            var result = new List<BigInteger>();
            BigInteger number = input[1];
            BigInteger divider = input[0];

            while (number / divider > 0)
            {
                result.Add(number % divider);
                number = number / divider;
            }
            result.Add(number);
            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}