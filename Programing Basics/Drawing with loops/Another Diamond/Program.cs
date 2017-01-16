using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenOrNor = 1;

            if (n % 2 == 0)
            {
                evenOrNor = 2;
            }

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else
            {

                Console.WriteLine("{0}{1}{0}", new string('-', (n - evenOrNor) / 2), new string('*', evenOrNor));

                for (int topPart = 1; topPart <= (n - 3) / 2; topPart++)
                {
                    int outterDashCount = (n - evenOrNor) / 2 - topPart;
                    int innerDashCount = n - 2 - (2 * outterDashCount);
                    string outterDash = new string('-', outterDashCount);
                    string innerDash = new string('-', innerDashCount);

                    Console.WriteLine("{0}*{1}*{0}", outterDash, innerDash);
                }

                Console.WriteLine("*{0}*", new string('-', n - 2));

                for (int bottomPart = (n - 3) / 2; bottomPart >= 1; bottomPart--)
                {
                    int outterDashCount = (n - evenOrNor) / 2 - bottomPart;
                    int innerDashCount = n - 2 - (2 * outterDashCount);
                    string outterDash = new string('-', outterDashCount);
                    string innerDash = new string('-', innerDashCount);

                    Console.WriteLine("{0}*{1}*{0}", outterDash, innerDash);
                }

                Console.WriteLine("{0}{1}{0}", new string('-', (n - evenOrNor) / 2), new string('*', evenOrNor));
            }
        }
    }
}
