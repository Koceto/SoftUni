using System;
using System.Linq;

namespace Find_Evens_or_Odds
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            string type = Console.ReadLine();
            
            Predicate<int[]> IsEven = range =>
            {
                for (int i = numbers[0]; i <= numbers[1]; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                return true;
            };

            Predicate<int[]> IsOdd = range =>
            {
                for (int i = numbers[0]; i <= numbers[1]; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                return true;
            };

            if (type == "even")
            {
                IsEven(numbers);
            }
            else
            {
                IsOdd(numbers);
            }
        }
    }
}