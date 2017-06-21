using System;
using System.Linq;

namespace Students_by_Group
{
    internal class Program
    {
        private static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var prefix = string.Join("", data.Last().ToCharArray().Take(5));

                if (prefix == "+3592" || (prefix[0] == '0' && prefix[1] == '2'))
                {
                    Console.WriteLine($"{data[0]} {data[1]}");
                }
            }
        }
    }
}