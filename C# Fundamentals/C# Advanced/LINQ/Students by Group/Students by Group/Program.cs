using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students_by_Group
{
    internal class Program
    {
        private static void Main()
        {
            string input;
            SortedSet<string> nameSet = new SortedSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(data.Last());

                if (index == 2)
                {
                    nameSet.Add($"{data[0]} {data[1]}");
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, nameSet));
        }
    }
}