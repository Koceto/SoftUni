namespace Count_Substring_Occurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .ToLower();
            var word = Console.ReadLine()
                .ToLower();
            var count = 0;
            var index = 0;

            while (true)
            {
                index = input.IndexOf(word, index);

                if (index >= 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                index++;
            }
            Console.WriteLine(count);

        }
    }
}