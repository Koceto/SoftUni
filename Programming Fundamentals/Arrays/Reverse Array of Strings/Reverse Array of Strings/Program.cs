using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    public class reverseArray
    {
        public static void Main()
        {
            string charsToReverse = Console.ReadLine();

            var myArray = charsToReverse.Split(' ');

            Array.Reverse(myArray);

            Console.WriteLine(string.Join(" ", myArray));
        }
    }
}
