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

                if (data.Any(m => m == "6"))
                {
                    Console.WriteLine($"{data[0]} {data[1]}");
                }
            }
        }
    }
}