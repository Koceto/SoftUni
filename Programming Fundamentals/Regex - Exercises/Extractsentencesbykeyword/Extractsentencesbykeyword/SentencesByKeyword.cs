namespace ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class SentencesByKeyword
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var text = Console.ReadLine()
                .Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex($@"[^\w]{keyword}[^\w]");

            foreach (var sentence in text)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
