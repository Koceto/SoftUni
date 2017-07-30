using System;
using System.Linq;

namespace Predicate_For_Names
{
    public static class StartUp
    {
        public static void Main()
        {
            Func<string, int, bool> LengthCheck = (currName, currLength) =>
            {
                if (currName.Length <= currLength)
                {
                    return true;
                }
                return false;
            };

            int length = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(Environment.NewLine,
                Console.ReadLine()
                .Split(' ')
                .Where(n => LengthCheck(n, length))));
        }
    }
}