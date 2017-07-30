using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Integers
{
    public class reverseArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(myArray);
            Console.WriteLine(string.Join(" ", myArray));
        }
    }
}
