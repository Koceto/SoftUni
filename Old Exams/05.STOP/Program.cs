using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', n * 2 + 1));

            for (int topRow = 0; topRow < n; topRow++)
            {
                string dot = new string('.', n - topRow);
                string underscore = new string('_', ((n * 4) + 3) - 4 - ((n - topRow) * 2));
                    Console.WriteLine(@"{0}//{1}\\{0}",dot, underscore);
            }

            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', ((n * 4) + 3 - 9) / 2));
            Console.WriteLine(@"\\{0}//", new string('_', (n * 4) + 3 - 4));

            for (int bottomRow = 1; bottomRow <= n - 1; bottomRow++)
            {
                string dot = new string('.', bottomRow);
                string underscore = new string('_', ((n * 4) + 3) - 4 - (bottomRow * 2));
                Console.WriteLine(@"{0}\\{1}//{0}", dot, underscore);
            }
        }
    }
}
