using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mathoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numOne, symbol, numTwo, (numOne + numTwo), (((numOne + numTwo) % 2 == 0) ? "even" : "odd"));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numOne, symbol, numTwo, (numOne - numTwo), (((numOne - numTwo) % 2 == 0) ? "even" : "odd"));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", numOne, symbol, numTwo, (numOne * numTwo), (((numOne * numTwo) % 2 == 0) ? "even" : "odd"));
                    break;
                case "/":
                    if (numTwo == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", numOne);
                        break;
                    }
                    Console.WriteLine("{0} {1} {2} = {3:f2}", numOne, symbol, numTwo, (numOne / (double)numTwo));
                    break;
                default:
                    if (numTwo == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", numOne);
                        break;
                    }
                    Console.WriteLine("{0} {1} {2} = {3}", numOne, symbol, numTwo, (numOne % numTwo));
                    break;
            }
        }
    }
}
