using System.Collections.Generic;

namespace Unique_Usernames
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                userNames.Add(input);
            }

            Console.WriteLine(string.Join("\n", userNames));
        }
    }
}