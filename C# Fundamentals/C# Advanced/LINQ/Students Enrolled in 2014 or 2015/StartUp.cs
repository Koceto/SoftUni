using System;
using System.Linq;

namespace Students_by_Group
{
    public static class StartUp
    {
        public static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var studentNumber = data.First().ToCharArray();

                if (studentNumber[4] == '1' && (studentNumber[5] == '4' || studentNumber[5] == '5'))
                {
                    Console.WriteLine(string.Join(" ", data.Skip(1)));
                }
            }
        }
    }
}