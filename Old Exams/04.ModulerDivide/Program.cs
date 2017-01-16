using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ModulerDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int divideByTwo = 0;
            int divideByThree = 0;
            int divideByFour = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    divideByTwo++;
                if (num % 3 == 0)
                    divideByThree++;
                if (num % 4 == 0)
                    divideByFour++;
            }
            double byTwo = (((divideByTwo * 1.0) / n)) * 100;
            double byThree = (((divideByThree * 1.0) / n)) * 100;
            double byFour = (((divideByFour * 1.0) / n)) * 100;

            Console.WriteLine("{0:f2}%", byTwo);
            Console.WriteLine("{0:f2}%", byThree);
            Console.WriteLine("{0:f2}%", byFour);
        }
    }
}
