namespace Melrah_Shake
{
    using System;
    using System.Text.RegularExpressions;

    public class HarlemShake
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            var justSoYouDontCopy = false;

            while (pattern.Length > 0)
            {
                var regexBack = new Regex(pattern, RegexOptions.RightToLeft);
                var regexFront = new Regex(pattern);

                if (regexFront.Matches(text.ToString()).Count >= 2 && !justSoYouDontCopy)
                {
                    text = regexFront.Replace(text.ToString(), string.Empty, 1);
                    text = regexBack.Replace(text.ToString(), string.Empty, 1);

                    Console.WriteLine("Shaked it.");

                    justSoYouDontCopy = true;
                }
                else
                {
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    justSoYouDontCopy = false;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
