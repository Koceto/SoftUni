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
            int charsPerRow = int.Parse(Console.ReadLine());
            int rows = charsPerRow;

            for (int upperPart = 0; upperPart < rows; upperPart++)
            {
                int space = charsPerRow - upperPart - 1;

                Console.Write("{0}{1}\n", new string(' ', space), string.Concat(Enumerable.Repeat("* ", upperPart + 1)));
            }
            for (int bottomPart = 0; bottomPart < rows - 1; bottomPart++)
            {
                int space = bottomPart + 1;

                Console.Write("{0}{1}\n", new string(' ', space), string.Concat(Enumerable.Repeat("* ", charsPerRow - bottomPart - 1)));
            }
        }
    }
}
