using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    public class PowerOfMath
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            long pow = long.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(number, pow));
        }

        public static double MathPower(double number, long pow)
        {
            double result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
