using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 1;
            int rowCount = 2;
            int roof = (n / 2) + 1;

            if (n % 2 == 0)
            {
                times = 2;
                roof = n / 2;
            }

            if (n <= 2)
            {
                Console.WriteLine("**");
                Console.WriteLine("||");
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - times) / 2), new string('*', times));

                for (int i = 1; i < roof; i++)
                {
                    int starCount = times + rowCount;
                    int dashCount = (n - starCount) / 2;
                    string star = new string('*', starCount);
                    string dash = new string('-', dashCount);

                    Console.WriteLine("{0}{1}{0}", dash, star);

                    rowCount += 2;
                }

                for (int b = 0; b < n / 2; b++)
                {
                    Console.WriteLine("|{0}|", new string('*', n - 2));
                }
            }
        }
    }
}
