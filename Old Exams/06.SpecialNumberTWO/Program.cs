using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpecialNumberTWO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int thousandths = 1; thousandths < 10; thousandths++)
            {
                for (int hundreds = 1; hundreds < 10; hundreds++)
                {
                    for (int tenths = 1; tenths < 10; tenths++)
                    {
                        for (int units = 1; units < 10; units++)
                        {
                            if (n % thousandths == 0 && n % hundreds == 0 && n % tenths == 0 && n % units == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", thousandths, hundreds, tenths, units);
                            }
                        }
                    }
                }
            }
        }
    }
}
