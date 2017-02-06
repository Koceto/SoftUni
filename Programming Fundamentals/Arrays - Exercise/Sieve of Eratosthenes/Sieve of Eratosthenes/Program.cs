using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var isPrime = new bool[n + 1];
            var numbers = new string[n + 1];

            for (int i = 0; i <= n; i++)
            {
                isPrime[i] = true;
            }

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    for (int a = 2; (a * i) <= n; a++)
                    {
                        isPrime[a * i] = false;
                    }
                }
            }

            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    numbers[i] = i.ToString();
                    numbers[i].Trim();
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
