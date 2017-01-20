using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            string sentense = string.Empty;

            sentense = firstWord + " " + secondWord;

            Console.WriteLine(sentense);
        }
    }
}
