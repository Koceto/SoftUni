using System;
using System.Collections.Generic;
using System.Text;

namespace NMS
{
    public static class StartUp
    {
        public static void Main()
        {
            Queue<string> wordQueue = new Queue<string>();
            StringBuilder message = new StringBuilder();
            string input;

            while ((input = Console.ReadLine()) != "---NMS SEND---")
            {
                wordQueue.Enqueue(input);
            }

            string delimiter = Console.ReadLine();

            while (wordQueue.Count > 0)
            {
                char[] currentWord = wordQueue.Dequeue().ToCharArray();

                for (int letterIndex = 0; letterIndex < currentWord.Length; letterIndex++)
                {
                    if (message.Length == 0)
                    {
                        message.Append(currentWord[0]);
                        continue;
                    }

                    if (Char.ToLower(currentWord[letterIndex]) < Char.ToLower(message[message.Length - 1]))
                    {
                        message.Append(delimiter);
                    }

                    message.Append(currentWord[letterIndex]);
                }
            }

            Console.WriteLine(message);
        }
    }
}