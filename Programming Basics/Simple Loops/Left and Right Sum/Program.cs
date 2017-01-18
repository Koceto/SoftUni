using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToWrite = int.Parse(Console.ReadLine());
            int leftNum = 0;
            int rightNum = 0;

            for (int writeLeft = 0; writeLeft < timesToWrite; writeLeft++)
            {
                int left = int.Parse(Console.ReadLine());

                leftNum += left;
            }

            for (int writeRight = 0; writeRight < timesToWrite; writeRight++)
            {

                int right = int.Parse(Console.ReadLine());

                rightNum += right;
            }

            if (leftNum == rightNum)
            {
                Console.WriteLine("Yes, sum = " + leftNum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftNum - rightNum));
            }
        }
    }
}
