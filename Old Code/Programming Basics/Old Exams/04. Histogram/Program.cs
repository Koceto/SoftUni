using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double lessThan200 = 0.0;
            double between200And399 = 0.0;
            double between400And599 = 0.0;
            double between600And799 = 0.0;
            double moreThan800 = 0.0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    lessThan200++;
                }
                else if (num >= 200 && num < 400)
                {
                    between200And399++;
                }
                else if (num >= 400 && num < 600)
                {
                    between400And599++;
                }
                else if (num >= 600 && num < 800)
                {
                    between600And799++;
                }
                else
                {
                    moreThan800++;
                }
            }
            lessThan200 = lessThan200 / n * 100;
            between200And399 = between200And399 / n * 100;
            between400And599 = between400And599 / n * 100;
            between600And799 = between600And799 / n * 100;
            moreThan800 = moreThan800 / n * 100;

            Console.WriteLine("{0:f2}%", lessThan200);
            Console.WriteLine("{0:f2}%", between200And399);
            Console.WriteLine("{0:f2}%", between400And599);
            Console.WriteLine("{0:f2}%", between600And799);
            Console.WriteLine("{0:f2}%", moreThan800);
        }
    }
}
