using System;
using System.Collections.Generic;

namespace Recursive_Fibonacci
{
    public static class StartUp
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var fibonacci = new Stack<long>();

            fibonacci.Push(0);
            fibonacci.Push(1);

            for (int i = 0; i < number - 1; i++)
            {
                var backuPop = fibonacci.Pop();
                var firstNumber = fibonacci.Peek();

                fibonacci.Push(backuPop);

                var secondNumber = fibonacci.Peek();

                fibonacci.Push(firstNumber + secondNumber);
            }

            Console.WriteLine(fibonacci.Peek());
        }
    }
}