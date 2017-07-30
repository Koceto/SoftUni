using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                int col = 0;

                for (; col < n - row; col++)
                {
                    Console.Write(row + col + 1 + " ");
                }

                for (int rCol = 1; rCol <= row; rCol++)
                {
                    Console.Write((n * 2) - (row + col) - rCol + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
