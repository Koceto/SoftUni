using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    public class EqualSums
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int equals = 0;
            int maxEquals = 0;
            bool noEqualSums = true;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int left = 0; left < a; left++)
                {
                    leftSum += numbers[left];
                    equals++;
                }

                for (int right = a + 1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }

                if (leftSum == rightSum)
                {
                    noEqualSums = false;
                }

                else
                {
                    leftSum = 0;
                    rightSum = 0;
                    equals = 0;
                }
                if (maxEquals < equals)
                {
                    maxEquals = equals;
                }

            }

            if (!noEqualSums)
            {
                Console.WriteLine(maxEquals);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
