using System;

namespace Letters_Change_Numbers
{
    public static class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var totalSum = 0D;

            foreach (var sequence in input)
            {
                var firstChar = sequence[0];
                var firstCharIndex = char.ToLower(firstChar) - 'a' + 1;
                var secondChar = sequence[sequence.Length - 1];
                var secondCharIndex = char.ToLower(secondChar) - 'a' + 1;
                var number = double.Parse(sequence.Substring(1, sequence.Length - 2)); // -1 for the count method (0,1,2..) and -1 for the starting index

                if (Char.IsUpper(firstChar))
                {
                    number /= firstCharIndex;
                }
                else
                {
                    number *= firstCharIndex;
                }

                if (Char.IsUpper(secondChar))
                {
                    number -= secondCharIndex;
                }
                else
                {
                    number += secondCharIndex;
                }
                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}