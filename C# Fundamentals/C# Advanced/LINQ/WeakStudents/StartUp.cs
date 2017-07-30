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
                var marks = data.Skip(2).Select(int.Parse).Where(m => m <= 3);

                if (marks.Count() >= 2)
                {
                    Console.WriteLine($"{data[0]} {data[1]}");
                }
            }
        }
    }
}