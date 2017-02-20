namespace Letters_Change_Numbers
{
    using System;
    using System.Text.RegularExpressions;

    public class LettersAndNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var reger = new Regex(@"\d+");
            var totalSum = 0M;

            foreach (var item in input)
            {
                char frontLetter = item[0];
                var number = decimal.Parse(reger.Match(item).ToString());
                char backLetter = item[item.Length - 1];

                if (char.IsUpper(frontLetter))
                {
                    number /= frontLetter - 'A' + 1;
                }
                else
                {
                    number *= frontLetter - 'a' + 1;
                }

                if (char.IsUpper(backLetter))
                {
                    number -= backLetter - 'A' + 1;
                }
                else
                {
                    number += backLetter - 'a' + 1;
                }
                totalSum += number;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
