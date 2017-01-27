using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    public class Program
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            for (int number = 1; number <= range; number++)
            {
                if (IsPalindrome(number.ToString()) && SumDevideBySeven(number.ToString()) && HasEvenDigit(number.ToString()))
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static bool HasEvenDigit(string number)
        {
            foreach (char symbol in number)
            {
                int digit = symbol - '0';
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool SumDevideBySeven(string number)
        {
            int result = 0;

            foreach (char symbol in number)
            {
                int digit = symbol - '0';
                result += digit;
            }
            if (result % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPalindrome(string number)
        {
            int min = 0;
            int max = number.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char first = number[min];
                char second = number[max];

                if (char.ToLower(first) != char.ToLower(second))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
