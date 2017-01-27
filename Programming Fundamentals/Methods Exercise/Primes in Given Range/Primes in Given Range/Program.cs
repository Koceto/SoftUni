using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    public class Program
    {
        public static void Main()
        {
            PrimesInRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            string printPrimes = null;

            Console.Write(string.Join(", ", new List<int>(MyList)));
        }

        public static void PrimesInRange(int primeFrom, int primeTo)
        {
            primeFrom = Math.Max(primeFrom, 2);
            MyList = new List<int>(primeFrom);

            for (int primeCheck = primeFrom; primeCheck <= primeTo; primeCheck++)
            {
                bool isPrime = true;

                for (int i = 2; i < primeCheck; i++)
                {
                    if (primeCheck % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    MyList.Add(primeCheck);
                }
            }
        }
        public static List<int> MyList;
    }
}
