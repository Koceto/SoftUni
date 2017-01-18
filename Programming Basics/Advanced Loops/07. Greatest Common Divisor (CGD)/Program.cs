using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int res = 0;

            while (numTwo != 0)
            {
                res = numTwo;
                numTwo = numOne % numTwo;
                numOne = res;
            }
            Console.WriteLine(res);
        }
    }
}
