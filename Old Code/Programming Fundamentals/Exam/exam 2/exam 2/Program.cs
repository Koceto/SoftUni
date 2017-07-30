using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exam_2
{

    public class Messages
    {
        public string Frequency { get; set; }

        public string Message { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var privateMessages = new List<Messages>();
            var broarcast = new List<Messages>();
            var regex = new Regex(@"\s<->\s");

            while (true)
            {
                var inputMessage = Console.ReadLine();

                if (inputMessage.ToLower() == "hornet is green")
                {
                    break;
                }

                var input = regex.Split(inputMessage);

                var querry = input
                    .First();

                var message = input
                    .Last();

                var validQuerry = querry.All(d => char.IsDigit(d));
                var validMes = querry.All(d => !char.IsDigit(d));
                var validMessage = message.All(m => char.IsDigit(m) || char.IsLetter(m));

                if (validQuerry && validMessage)
                {
                    querry = string.Join("", querry.ToCharArray().Reverse());

                    privateMessages.Add(new Messages
                    {
                        Frequency = querry,
                        Message = message
                    });
                }
                else if (validMes && validMessage)
                {
                    message = Reverse(message);

                    broarcast.Add(new Messages
                    {
                        Frequency = querry,
                        Message = message
                    });
                }
            }

            Console.WriteLine("Broadcasts:");

            if (broarcast.Count > 0)
            {
                foreach (var bCast in broarcast)
                {
                    Console.WriteLine($"{bCast.Message} -> {bCast.Frequency}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (privateMessages.Count > 0)
            {
                foreach (var privMessage in privateMessages)
                {
                    Console.WriteLine($"{privMessage.Frequency} -> {privMessage.Message}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        private static string Reverse(string message)
        {
            var temp = message.ToCharArray();

            for (int i = 0; i < message.Length; i++)
            {
                var currSym = temp[i];

                if (char.IsLetter(currSym))
                {
                    if (char.IsLower(currSym))
                    {
                        temp[i] = char.ToUpper(currSym);
                    }
                    else if (char.IsUpper(currSym))
                    {
                        temp[i] = char.ToLower(currSym);
                    }
                }
            }
            return string.Join("", temp);
        }
    }
}
