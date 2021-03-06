﻿using System;
using System.Collections.Generic;

namespace Students_by_Group
{
    public static class StartUp
    {
        public static void Main()
        {
            string input;
            HashSet<string> nameSet = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firstName = data[0];
                string lastname = data[1];
                int age = int.Parse(data[2]);

                if (age >= 18 && age <= 24)
                {
                    nameSet.Add($"{firstName} {lastname} {age}");
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, nameSet));
        }
    }
}