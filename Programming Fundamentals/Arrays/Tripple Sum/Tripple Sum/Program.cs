using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_Sum
{
    public class sum
    {
        public static void Main()
        {
            var number = Console.ReadLine();
            var myArray = number.Split(' ').Select(int.Parse).ToArray();
            bool hasTriples = true;

            for (int a = 0; a < myArray.Length; a++)
            {
                int sum = 0;
                for (int b = a; b < myArray.Length; b++)
                {
                    sum = myArray[a] + myArray[b];
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        if (sum == myArray[i] && a != b)
                        {
                            Console.WriteLine($"{myArray[a]} + {myArray[b]} == {myArray[i]}");
                            hasTriples = false;
                            break;
                        }
                    }
                }
            }
            if (hasTriples)
            {
                Console.WriteLine("No");
            }
        }
    }
}
