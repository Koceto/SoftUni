using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine()
                .Split()
                .ToArray();
            int bombNumber = int.Parse(command[0]);
            int bombPower = int.Parse(command[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (bombNumber == numbers[i])
                {
                    int removeFrom = Math.Max((i - bombPower), 0);
                    int elementsToRemove = Math.Min(bombPower + 1 + i - removeFrom, numbers.Count() - removeFrom);

                    numbers.RemoveRange(removeFrom, elementsToRemove);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }
    }
}
