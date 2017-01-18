using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Specialnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1111; number <= 9999; number++)
            {
                bool isSpecial = true;
                int tempNumber = number;

                while (tempNumber != 0)
                {
                    int lastNum = tempNumber % 10;
                    tempNumber /= 10;

                    if ((lastNum == 0) || (n % lastNum != 0))
                    {
                        isSpecial = false;
                        break;
                    }
                    else
                    {
                        isSpecial = true;
                    }
                }

                if (isSpecial)
                {
                    Console.Write("{0} ", number);
                }
            }
        }
    }
}
