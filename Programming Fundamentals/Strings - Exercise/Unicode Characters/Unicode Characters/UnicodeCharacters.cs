namespace Unicode_Characters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .ToCharArray();
            var stringBuild = new StringBuilder();

            foreach (var symbol in input)
            {
                stringBuild.Append(@"\u" + ((int)symbol).ToString("x4"));
            }
            Console.WriteLine(stringBuild.ToString());
        }
    }
}
