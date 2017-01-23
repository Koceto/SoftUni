using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    public class FilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            TopAndBottomOfSquare(n);
            BodyOfSquare(n);
            TopAndBottomOfSquare(n);
        }

        public static void TopAndBottomOfSquare(int n)
        {
            Console.WriteLine("{0}",
                new string('-', n * 2));
        }

        public static void BodyOfSquare(int n)
        {
            for (int row = 0; row < n - 2; row++)
            {
                int repeatScheme = ((n * 2) - 2) / 2;
                Console.WriteLine("{0}{1}{0}",
                    new string('-', 1),
                    string.Concat(Enumerable.Repeat(@"\/", repeatScheme)));
            }
        }
    }
}
