namespace CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TheGreatCubicArmy
    {
        public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "over!")
                {
                    break;
                }

                var charCount = int.Parse(Console.ReadLine());
                var digits = new List<int>();
                var chars = new List<char>();
                var finalMessage = new List<char>();

                if (!GetMessage(input, charCount, digits, chars))
                {
                    continue;
                }

                foreach (var digit in digits)
                {
                    if (digit >= 0 && digit < chars.Count())
                    {
                        finalMessage.Add(chars[digit]);
                    }
                    else
                    {
                        finalMessage.Add(' ');
                    }
                }
                var cryptedMessage = string.Join("", chars);
                var deCryptedMessage = string.Join("", finalMessage);

                Console.WriteLine($"{cryptedMessage} == {deCryptedMessage}");
            }
        }

        public static bool GetMessage(string input, int charCount, List<int> digits, List<char> chars)
        {
            var firstLetterFromMessage = default(char);

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    firstLetterFromMessage = input[i];
                    break;
                }
            }
            var indexOfMessage = input.IndexOf(firstLetterFromMessage);
            var message = input.Substring(indexOfMessage, charCount);

            if (message.All(c => char.IsLetter(c)))
            {
                var numbersValidator = input.Substring(0, indexOfMessage);

                if (numbersValidator.All(d => char.IsDigit(d)))
                {
                    var afterMessageValidator = input.Substring(indexOfMessage + charCount, input.Length - (indexOfMessage + charCount));
                    if (!afterMessageValidator.Any(c => char.IsLetter(c)))
                    {
                        foreach (var sym in input.ToCharArray())
                        {
                            if (char.IsLetter(sym))
                            {
                                chars.Add(sym);
                            }
                            else if (char.IsDigit(sym))
                            {
                                digits.Add(int.Parse(sym.ToString()));
                            }
                        }
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
