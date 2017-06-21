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
            HashSet<string> nameSet = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firstName = data[0];
                string lastname = data[1];

                if (firstName.CompareTo(lastname) == -1)
                {
                    nameSet.Add($"{data[0]} {data[1]}");
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, nameSet));
        }
    }
}