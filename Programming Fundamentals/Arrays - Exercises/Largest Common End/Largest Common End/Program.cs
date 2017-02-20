using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    public class Program
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int shorterArray = Math.Min(firstArray.Length, secondArray.Length);

            int firstTemp = 0;
            int secondTemp = 0;

            for (int i = 0; i < shorterArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    firstTemp++;
                }
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    secondTemp++;
                }
            }
            if (firstTemp > secondTemp || (firstTemp == secondTemp || firstTemp != 0))
            {
                Console.WriteLine(firstTemp);
            }
            else if (firstTemp < secondTemp)
            {
                Console.WriteLine(secondTemp);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
