using System;
using System.Linq;

namespace Action_Print
{
    internal class Program
    {
        private static void Main()
        {
            Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}