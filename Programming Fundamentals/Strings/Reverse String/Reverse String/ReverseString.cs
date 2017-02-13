namespace Reverse_String
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    public class ReverseString
    {
        public static void Main()
        {
            var result = Console.ReadLine()
                .ToCharArray();

            var output = result.Reverse();

            Console.WriteLine(string.Join("", output));
        }
    }
}
