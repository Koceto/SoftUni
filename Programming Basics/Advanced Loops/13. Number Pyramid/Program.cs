using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 1; n >= num; row++)
            {
                for (int col = 0; col < row; col++, num++)
                {
                    Console.Write(num + " ");
                    if (num == n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
