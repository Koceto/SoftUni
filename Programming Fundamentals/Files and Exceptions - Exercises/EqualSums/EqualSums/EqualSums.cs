using System;
using System.IO;
using System.Linq;

namespace EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            var filePath = @"..\..\";
            var numbers = File.ReadAllText(filePath + "input.txt")
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var leftResult = 0;

                for (int a = 0; a < i; a++)
                {
                    leftResult += numbers[a];
                }

                var rightResult = 0;

                for (int b = i + 1; b <= numbers.Length - 1; b++)
                {
                    rightResult += numbers[b];
                }

                if (leftResult == rightResult)
                {
                    Console.WriteLine(i);
                    File.WriteAllText(filePath + "result.txt", i.ToString());
                    return;
                }
            }

            File.WriteAllText(filePath + "result.txt", "no");
        }
    }
}
