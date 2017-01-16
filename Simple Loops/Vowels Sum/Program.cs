using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char vowels = new char();
            int result = 0;

            for (int repeat = 0; repeat <= (text.Length - 1); repeat++)
            {
                vowels = text[repeat];

                switch (vowels)
                {
                    case 'a':
                        result += 1;
                        break;
                    case 'e':
                        result += 2;
                        break;
                    case 'i':
                        result += 3;
                        break;
                    case 'o':
                        result += 4;
                        break;
                    case 'u':
                        result += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
