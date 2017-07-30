using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_and_Sum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            var leftSideTopRow = numbers
                .Take(k)
                .Reverse();
            var RightSideTopRow = numbers
                .Reverse()
                .Take(k);
            var bottomRow = numbers
                .Skip(k)
                .Take(k * 2);
            var topRow = leftSideTopRow.Concat(RightSideTopRow);

            var result = topRow.Zip(bottomRow, (x, y) => (x + y));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
