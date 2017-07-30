using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int specialNumber = 1; specialNumber <= n; specialNumber++)
            {
                int lastDigitSum = 0;
                int backupNumber = specialNumber;
                while (backupNumber != 0)
                {
                    lastDigitSum += backupNumber % 10;
                    backupNumber /= 10;
                }
                if (lastDigitSum == 5 || lastDigitSum == 7 || lastDigitSum == 11)
                {
                    Console.WriteLine($"{specialNumber} -> True");
                }
                else
                {
                    Console.WriteLine($"{specialNumber} -> False");
                }
            }
        }
    }
}
