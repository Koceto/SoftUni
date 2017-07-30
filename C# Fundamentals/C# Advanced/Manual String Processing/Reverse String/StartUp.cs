using System;
using System.Linq;
using System.Text;

namespace Reverse_String
{
    public static class StartUp
    {
        private static void Main()
        {
            var inputString = Console.ReadLine().ToCharArray().Reverse();
            var builder = new StringBuilder();

            foreach (var charPrint in inputString)
            {
                builder.Append(charPrint);
            }

            Console.WriteLine(builder);
        }
    }
}