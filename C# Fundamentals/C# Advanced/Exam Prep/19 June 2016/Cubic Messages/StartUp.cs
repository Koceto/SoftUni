using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cubic_Messages
{
    public static class StartUp
    {
        public const string EndCommand = "Over!";
        public const string Pattern = @"^(\d+)([A-Za-z]+)([^a-zA-Z\s]*$)";

        public static void Main()
        {
            string input;
            Queue<string> allMessages = new Queue<string>();
            Regex regex = new Regex(Pattern);

            while ((input = Console.ReadLine()) != EndCommand)
            {
                int verificationCode = int.Parse(Console.ReadLine());
                Match match = regex.Match(input);
                StringBuilder message = new StringBuilder();

                if (match.Success && match.Groups[2].Length == verificationCode)
                {
                    string encryptedMessage = match.Groups[2].ToString();
                    string firstPart = match.Groups[1].ToString();
                    string secondPart = match.Groups[3].ToString();

                    foreach (char part in string.Concat(firstPart, secondPart))
                    {
                        if (Char.IsDigit(part))
                        {
                            int index = int.Parse(part.ToString());

                            if (index >= 0 && index < encryptedMessage.Length)
                            {
                                message.Append(encryptedMessage[index]);
                            }
                            else
                            {
                                message.Append(' ');
                            }
                        }
                    }
                }

                if (message.Length != 0)
                {
                    allMessages.Enqueue($"{match.Groups[2]} == {message}");
                }
            }

            foreach (var message in allMessages)
            {
                Console.WriteLine(message);
            }
        }
    }
}