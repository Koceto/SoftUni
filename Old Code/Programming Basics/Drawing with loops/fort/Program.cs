using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string arrow = new string('^', n / 2);
            int middle = (n * 2) - (((n / 2) * 2) + 4);
            string middleWall = new string('_', middle);
            string bottomMidWall = new string(' ', middle);

            Console.WriteLine(@"/{0}\{1}/{0}\", arrow, middleWall);

            for (int rows = 0; rows < n - 3; rows++)
            {
                Console.WriteLine("|{0}|", new string(' ', (n * 2) - 2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ', (n / 2) + 1), middleWall);
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), bottomMidWall);
        }
    }
}
