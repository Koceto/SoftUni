using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Most_Frequent_Number
{
    public class FrequentNumber
    {
        public static void Main()
        {
            var input = File.ReadAllText(@"..\..\input.txt")
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var result = new Dictionary<int, int>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result[input[i]] = 0;
                }
                result[input[i]]++;
            }

            File.WriteAllText(@"..\..\result.txt", string.Join("", result
                .OrderByDescending(x => x.Value)
                .Take(1)
                .Select(x => x.Key)));
        }
    }
}
