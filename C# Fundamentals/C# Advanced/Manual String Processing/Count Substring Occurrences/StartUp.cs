using System;

namespace Count_Substring_Occurrences
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var word = Console.ReadLine();
            var counter = 0;

            while (text.IndexOf(word) != -1)
            {
                var index = text.IndexOf(word, StringComparison.InvariantCultureIgnoreCase);
                text = text.Remove(index, 1);
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}