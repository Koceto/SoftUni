using System;
using System.Linq;

namespace Reverse_And_Exclude
{
    public static class StartUp
    {
        public static void Main()
        {
            Func<int, int, bool> IsDividable = (n, d) =>
            {
                if (n % d == 0)
                {
                    return true;
                }
                return false;
            };

            var numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse);
            var divider = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", numbers.Where(n => !IsDividable(n, divider)).Reverse()));
        }
    }
}