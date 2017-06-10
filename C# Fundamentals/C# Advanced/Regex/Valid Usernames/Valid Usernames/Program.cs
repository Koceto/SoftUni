using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^[A-Za-z]\w{2,24}$";
            Regex regex = new Regex(pattern);
            int maxSum = default(int);
            string[] usernamesToPrint = new string[2];
            var validUserNames = new List<string>();

            foreach (var userName in input)
            {
                var match = regex.Match(userName);

                if (match.Success)
                {
                    validUserNames.Add(userName);
                }
            }

            for (int i = 1; i < validUserNames.Count; i++)
            {
                string previousWord = validUserNames[i - 1];
                string currentWord = validUserNames[i];
                int currentSum = previousWord.Length + currentWord.Length;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    usernamesToPrint[0] = previousWord;
                    usernamesToPrint[1] = currentWord;
                }
            }

            Console.WriteLine(usernamesToPrint[0]);
            Console.WriteLine(usernamesToPrint[1]);
        }
    }
}