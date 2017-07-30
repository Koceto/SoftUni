using System;

namespace Unicode_Characters
{
    public static class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim();

            foreach (char symbol in input)
            {
                Console.Write("\\u" + ((int)symbol).ToString("X").PadLeft(4, '0').ToLower());
            }
        }
    }
}