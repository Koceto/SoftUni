using System;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Lake lake = new Lake(input);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}