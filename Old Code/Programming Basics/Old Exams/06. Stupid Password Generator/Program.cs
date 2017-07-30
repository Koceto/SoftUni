using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int number1 = 1; number1 <= n; number1++)
            {
                for (int number2 = 1; number2 <= n; number2++)
                {
                    for (char number3 = 'a'; number3 < 'a' + l ; number3++)
                    {
                        for (char number4 = 'a'; number4 < 'a' + l; number4++)
                        {
                            for (int number5 = 1; number5 <= n; number5++)
                            {
                                if (number5 > Math.Max(number1, number2))
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", number1, number2, number3, number4, number5);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
