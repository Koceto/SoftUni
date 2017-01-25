using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sumElements = int.Parse(Console.ReadLine());

            var myArray = new long[number];
            myArray[0] = 1;

            for (int i = 1; i < myArray.Length; i++)
            {
                for (int i2 = 1; i2 <= sumElements; i2++)
                {
                    if (i -i2 < 0)
                    {
                        break;
                    }
                    myArray[i] += myArray[i - i2];
                }
            }
            Console.WriteLine(string.Join(" ", myArray));
        }
    }
}
