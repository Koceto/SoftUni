using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Little_John
{
    public static class StartUp
    {
        public const string SmallArraw = ">----->";
        public const string MediumArrow = ">>----->";
        public const string BigArrow = ">>>----->>";
        public const string Arrows = @">+-+>+";

        public static void Main()
        {
            int bigAtrrows = 0;
            int mediumArrows = 0;
            int smallAtrrows = 0;

            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();
                MatchCollection arrows = Regex.Matches(input, Arrows);

                foreach (Match arrow in arrows)
                {
                    if (Regex.Match(arrow.ToString(), BigArrow).Success)
                    {
                        bigAtrrows++;
                    }
                    else if (Regex.Match(arrow.ToString(), MediumArrow).Success)
                    {
                        mediumArrows++;
                    }
                    else if (Regex.Match(arrow.ToString(), SmallArraw).Success)
                    {
                        smallAtrrows++;
                    }
                }
            }

            long encryption = long.Parse(string.Concat(smallAtrrows, mediumArrows, bigAtrrows));
            encryption = long.Parse(Convert.ToString(encryption, 2));
            long original = encryption;
            string binary = string.Concat(original, string.Join("", encryption.ToString().ToCharArray().Reverse()));
            encryption = long.Parse(Convert.ToInt64(binary, 2).ToString());
            Console.WriteLine(encryption);
        }
    }
}