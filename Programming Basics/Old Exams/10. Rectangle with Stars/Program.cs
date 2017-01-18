using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2;

            for (int topRows = 1; topRows <= (n + 1) / 2; topRows++)
            {
                Console.WriteLine("%{0}%", topRows == 1 ?
                    new string('%', width - 2) :
                    new string(' ', width - 2));
            }
            Console.WriteLine("%{0}**{0}%", new string(' ', width / 2 - 2));

            for (int topRows = 1; topRows <= (n + 1) / 2; topRows++)
            {
                Console.WriteLine("%{0}%", topRows == (n + 1) / 2 ?
                    new string('%', width - 2) :
                    new string(' ', width - 2));
            }
        }
    }
}
