﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_form
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Console.ReadLine();
            var lastname = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-year old person from {3}.", firstname, lastname, age, town);
        }
    }
}
