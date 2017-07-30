using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    public class Triangle
    {
        public static void Main()
        {
            int numberToPrint = int.Parse(Console.ReadLine());
            PrintTop(numberToPrint);
            PrintBottom(numberToPrint);
        }

        private static void PrintTop(int numberToPrint)
        {
            for (int row = 1; row <= numberToPrint; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintBottom(int numberToPrint)
        {
            for (int row = 1; row < numberToPrint; row++)
            {
                for (int col = 1; col <= numberToPrint - row; col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }
    }
}
