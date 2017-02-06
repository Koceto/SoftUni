using System;
using System.Collections.Generic;
using System.Linq;

namespace Fix_Emails
{
    public class FixEmails
    {
        public static void Main()
        {
            var contacts = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                
                if (name == "stop")
                {
                    foreach (var item in contacts)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    return;
                }

                string email = Console.ReadLine();
                var emailChecker = email
                    .ToCharArray();
                contacts[name] = email;

                for (int i = emailChecker.Length - 1; i >= emailChecker.Length - 2; i--)
                {
                    if (emailChecker[i - 1] == 'u' && (emailChecker[i] == 'k' || emailChecker[i] == 's'))
                    {
                        contacts.Remove(name);
                        break;
                    }
                }
            }
        }
    }
}
