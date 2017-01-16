using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            int timeToRepeat = int.Parse(Console.ReadLine());
            double maxValueEven = double.MinValue;
            double minValueEven = double.MaxValue;
            double maxValueOdd = double.MinValue;
            double minValueOdd = double.MaxValue;
            double even = new double();
            double odd = new double();

            for (int repeat = 1; repeat <= timeToRepeat; repeat++)
            {
                double num = double.Parse(Console.ReadLine());

                if (repeat % 2 == 0)
                {
                    if (num > maxValueEven)
                    {
                        maxValueEven = num;
                    }
                    if (num < minValueEven)
                    {
                        minValueEven = num;
                    }
                    even += num;

                }
                else
                {
                    if (num > maxValueOdd)
                    {
                        maxValueOdd = num;
                    }
                    if (num < minValueOdd)
                    {
                        minValueOdd = num;
                    }
                    odd += num;
                }
            }

            Console.WriteLine("OddSum=" + odd);
            if (minValueOdd != double.MaxValue)
            {
                Console.WriteLine("OddMin=" + minValueOdd);
            }
            else
            {
                Console.WriteLine("OddMin=No");
            }

            if (maxValueOdd != double.MinValue)
            {
                Console.WriteLine("OddMax=" + maxValueOdd);
            }
            else
            {
                Console.WriteLine("OddMax=No");
            }

            Console.WriteLine("EvenSum=" + even);
            if (minValueEven != double.MaxValue)
            {
                Console.WriteLine("EvenMin=" + minValueEven);
            }
            else
            {
                Console.WriteLine("EvenMin=No");
            }

            if (maxValueEven != Double.MinValue)
            {
                Console.WriteLine("EvenMax=" + maxValueEven);
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
