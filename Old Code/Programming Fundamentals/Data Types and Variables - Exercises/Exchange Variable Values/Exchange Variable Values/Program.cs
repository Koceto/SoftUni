using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstValue}");
            Console.WriteLine($"b = {secondValue}");

            firstValue = firstValue + secondValue;
            secondValue = firstValue - secondValue;
            firstValue = firstValue - secondValue;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstValue}");
            Console.WriteLine($"b = {secondValue}");
        }
    }
}
