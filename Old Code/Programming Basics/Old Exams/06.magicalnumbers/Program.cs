using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.magicalnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicalNumber = int.Parse(Console.ReadLine());

            for (int number1 = 1; number1 < 10; number1++)
            {
                for (int number2 = 1; number2 < 10; number2++)
                {
                    for (int number3 = 1; number3 < 10; number3++)
                    {
                        for (int number4 = 1; number4 < 10; number4++)
                        {
                            for (int number5 = 1; number5 < 10; number5++)
                            {
                                for (int number6 = 1; number6 < 10; number6++)
                                {
                                    if (number1 * number2 * number3 * number4 * number5 * number6 == magicalNumber)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", number1, number2, number3, number4, number5, number6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
