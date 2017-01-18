using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fallen_In_Love
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roseCounter = 1;

            for (int topRows = 0; topRows < n; topRows++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                    new string('~', topRows),
                    new string('.', (n * 2) - (topRows * 2)),
                    new string('.', topRows * 2));
            }
            for (int bottomRows = 0; bottomRows < n; bottomRows++, roseCounter += 2)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                    new string('.', roseCounter),
                    new string('~', n - bottomRows),
                    new string('.', (n * 2) - (bottomRows * 2)));
            }
            Console.WriteLine("{0}####{0}",
                new string('.', n * 2 + 1));
            for (int handle = 0; handle < n; handle++)
            {
                Console.WriteLine("{0}##{0}",
                    new string('.', n * 2 + 2));
            }
        }
    }
}
