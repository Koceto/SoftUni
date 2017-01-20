using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int firstLoop = 2; firstLoop <= number; firstLoop++)
            {
                bool isItPrime = true;
                for (int secondLoop = 2; secondLoop <= Math.Sqrt(firstLoop); secondLoop++)
                {
                    if (firstLoop % secondLoop == 0)
                    {
                        isItPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{firstLoop} -> {isItPrime}");
            }
        }
    }
}
