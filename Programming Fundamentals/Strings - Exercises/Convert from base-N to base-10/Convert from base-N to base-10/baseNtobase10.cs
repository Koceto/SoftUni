using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Convert_from_base_N_to_base_10
{
    public class baseNtobase10
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var result = new List<BigInteger>();
            var number = input[1]
                .ToCharArray()
                .Reverse()
                .ToArray();
            var divider = BigInteger.Parse(input[0]);

            for (int i = 0; i < number.Count(); i++)
            {
                result.Add(BigInteger.Parse(number[i].ToString()) * BigInteger.Pow(divider, i));
            }

            Console.WriteLine(string.Join("", result.Aggregate((x, y) => x + y)));
        }
    }
}
