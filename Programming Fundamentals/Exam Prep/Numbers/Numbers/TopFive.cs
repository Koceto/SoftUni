namespace Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class TopFive
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var average = input.Average();
            var result = new List<long>();

            foreach (var number in input.OrderByDescending(n => n))
            {
                if (number > average && result.Count < 5)
                {
                    result.Add(number);
                }
            }
            if (result.Count != 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
