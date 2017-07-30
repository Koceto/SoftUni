using System;
using System.Linq;

namespace Action_Print
{
    public static class StartUp
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}