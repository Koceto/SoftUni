using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ButterFly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n - 2; rows++)
            {
                Console.WriteLine(@"{0}\ /{0}", rows % 2 == 0 ?
                    new string('-', n - 2) :
                    new string('*', n - 2));
            }
            Console.WriteLine("{0}@{0}", new string(' ',n - 1));

            for (int rows = 1; rows <= n - 2; rows++)
            {
                Console.WriteLine(@"{0}/ \{0}", rows % 2 == 0 ?
                    new string('-', n - 2) :
                    new string('*', n - 2));
            }
        }
    }
}
