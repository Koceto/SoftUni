using System;
using System.Linq;

namespace Text_Filter
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var word in words)
            {
                var replacementString = String.Concat(Enumerable.Repeat("*", word.Length));
                text = text.Replace(word, replacementString);
            }

            Console.WriteLine(text);
        }
    }
}