using System;

namespace Melrah_Shake
{
    public static class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var firstIndex = text.IndexOf(pattern);
                var lastindex = text.LastIndexOf(pattern);

                if (firstIndex != -1 &&
                    lastindex != -1 &&
                    firstIndex != lastindex)
                {
                    text = text.Remove(firstIndex, pattern.Length);
                    text = text.Remove(lastindex - pattern.Length, pattern.Length);

                    Console.WriteLine("Shaked it.");

                    if (pattern.Length == 1)
                    {
                        break;
                    }

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}