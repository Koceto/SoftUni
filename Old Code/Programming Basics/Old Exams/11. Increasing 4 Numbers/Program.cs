using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int num1 = a; num1 <= b; num1++)
            {
                for (int num2 = a; num2 <= b; num2++)
                {
                    for (int num3 = a; num3 <= b; num3++)
                    {
                        for (int num4 = a; num4 <= b; num4++)
                        {
                            if (num1 < num2 && num2 < num3 && num3 < num4)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", num1, num2, num3, num4);
                            }
                            else if (b - a < 3)
                            {
                                Console.WriteLine("No");
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
