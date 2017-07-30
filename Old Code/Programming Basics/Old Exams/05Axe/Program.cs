using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalWidth = n * 5;

            for (int topRow = 0; topRow < n; topRow++)
            {
                int rightDash = n * 2 - 2 - topRow;
                int midDash = topRow;
                int leftDash = totalWidth - 2 - rightDash - midDash;

                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDash),
                    new string('-', midDash),
                    new string('-', rightDash));
            }
            for (int midRow = 0; midRow < n / 2; midRow++)
            {
                int handle = n * 3;
                int dash = (totalWidth - 2 - handle) / 2;
                Console.WriteLine("{0}*{1}*{1}",
                    new string('*', handle),
                    new string('-', dash));
            }
            for (int bottomRow = 0; bottomRow < n / 2; bottomRow++)
            {
                int leftDash = n * 3 - bottomRow;
                int rightDash = n - 1 - bottomRow;
                int midDash = totalWidth - 2 - leftDash - rightDash;
                string midDashString = new string('-', midDash);
                string midStarString = new string('*', midDash);

                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDash),
                    bottomRow != n / 2 - 1 ? midDashString : midStarString,
                    new string('-', rightDash));
            }
        }
    }
}
