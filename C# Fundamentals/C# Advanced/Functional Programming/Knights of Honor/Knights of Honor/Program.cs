using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Knights_of_Honor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ')
                .ToList()
                .ForEach(n => Console.WriteLine($"Sir {n}"));
        }
    }
}