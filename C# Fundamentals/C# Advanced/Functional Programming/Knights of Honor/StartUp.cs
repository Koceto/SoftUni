using System;
using System.Linq;

namespace Knights_of_Honor
{
    public static class StartUp
    {
        public static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ')
                .ToList()
                .ForEach(n => Console.WriteLine($"Sir {n}"));
        }
    }
}