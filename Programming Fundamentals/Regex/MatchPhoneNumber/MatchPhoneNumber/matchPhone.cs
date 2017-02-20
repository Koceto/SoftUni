namespace MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhone
    {
        public static void Main()
        {
            var phoneNumber = @"359-2-222-2222, +359/2/222/2222, +359-2 222 2222, +359 2 222 2222";
            var regex = new Regex(@"\+[0-9]{3}\s[0-9]\s[0-9]{3}\s[0-9]{4}");
            var result = regex.Matches(phoneNumber);

            foreach (Match item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
