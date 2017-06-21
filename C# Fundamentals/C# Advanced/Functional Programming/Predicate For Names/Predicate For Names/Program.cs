using System;
using System.Linq;

namespace Predicate_For_Names
{
    internal class Program
    {
        private static void Main()
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