using System;
using System.Linq;

namespace Applied_Arithmetics
{
    public static class StartUp
    {
        public static void Main()
        {
            Func<int, int> Add = currentNumber =>
            {
                return currentNumber + 1;
            };

            Func<int, int> Subtract = currentNumber =>
            {
                return currentNumber - 1;
            };

            Func<int, int> Multiply = currentNumber =>
            {
                return currentNumber * 2;
            };

            int[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    var temp = numbers.Select(Add).ToArray();
                    numbers = temp;
                }
                else if (command == "subtract")
                {
                    var temp = numbers.Select(Subtract).ToArray();
                    numbers = temp;
                }
                else if (command == "multiply")
                {
                    var temp = numbers.Select(Multiply).ToArray();
                    numbers = temp;
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
        }
    }
}