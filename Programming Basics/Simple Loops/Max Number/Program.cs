using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToWrite = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int write = 0; write < timesToWrite; write++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (currNum >= maxNumber)
                {
                    maxNumber = currNum;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
