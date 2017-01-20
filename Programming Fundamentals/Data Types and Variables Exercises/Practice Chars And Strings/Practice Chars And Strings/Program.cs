using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDataString = Console.ReadLine();
            char firstDataChar = char.Parse(Console.ReadLine());
            char secondDataChar = char.Parse(Console.ReadLine());
            char thirdDataChar = char.Parse(Console.ReadLine());
            string secondDataString = Console.ReadLine();

            Console.WriteLine(firstDataString);
            Console.WriteLine(firstDataChar);
            Console.WriteLine(secondDataChar);
            Console.WriteLine(thirdDataChar);
            Console.WriteLine(secondDataString);
        }
    }
}
