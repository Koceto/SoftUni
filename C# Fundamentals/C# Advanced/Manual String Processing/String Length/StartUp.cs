using System;

namespace String_Length
{
    public static class StartUp
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            if (inputString.Length < 20)
            {
                var resultString = inputString.PadRight(20, '*');
                Console.WriteLine(resultString);
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(inputString[i]);
                }
            }
        }
    }
}