using System;
using System.Linq;

namespace Text_Filter
{
    public class TextFilter
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var text = Console.ReadLine();

            foreach (var word in words)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
