using System;
using System.Collections.Generic;
using System.Linq;

namespace Fix_Emails
{
    public class Program
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();

            while (true)
            {
                var currName = Console.ReadLine();

                if (currName.ToLower() == "stop")
                {
                    break;
                }

                var currEmail = Console.ReadLine();
                var emailDomain = currEmail.Split(new[] {'.'}).Last();

                if (emailDomain.ToLower() == "uk" || emailDomain.ToLower() == "us")
                {
                    continue;
                }

                if (emails.ContainsKey(currName))
                {
                    emails[currName] = currEmail;
                }
                else
                {
                    emails.Add(currName, currEmail);
                }
            }

            foreach (var email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}