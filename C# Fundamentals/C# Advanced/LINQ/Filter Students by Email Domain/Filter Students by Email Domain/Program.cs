﻿using System;
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

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

                if (data.Last() == "gmail.com")
                {
                    var names = data[0].Split(' ');

                    Console.WriteLine($"{names[0]} {names[1]}");
                }
            }
        }
    }
}