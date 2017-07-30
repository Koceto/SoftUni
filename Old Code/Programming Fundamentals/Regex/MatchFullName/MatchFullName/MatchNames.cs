namespace MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchNames
    {
        public static void Main()
        {
            var text = "Ivan Ivanov otide na razhodka zaedno s Pesho Peshov i dvamata vidqha Iliqn Penov";
            var regex = new Regex(@"[A-Z][a-z]+\s[A-Z][a-z]+");
            var result = regex.Matches(text);

            foreach (Match item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
