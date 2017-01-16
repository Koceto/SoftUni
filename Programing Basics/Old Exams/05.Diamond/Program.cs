using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalWidth = n * 5;

            for (int topRow = 0; topRow < n; topRow++)
            {
                int leftRightDot = n - topRow;
                int midDot = totalWidth - 2 - (leftRightDot * 2);
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', leftRightDot),
                    topRow == 0 ? new string('*', midDot) :
                    new string('.', midDot));
            }

            Console.WriteLine("{0}", new string('*', totalWidth));

            for (int row = 1; row <= n * 2 + 1; row++)
            {
                int leftRightDot = row;
                int midDot = totalWidth - 2 - (leftRightDot * 2);
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', leftRightDot),
                    row == (n * 2 + 1) ? new string('*', midDot) :
                    new string('.', midDot));
            }
        }
    }
}
