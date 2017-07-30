using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double ammount = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.5;
                        break;
                    case "apple":
                        price = 1.2;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.7;
                        break;
                    case "pineapple":
                        price = 5.5;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    default:
                        break;
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.7;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.9;
                        break;
                    case "grapefruit":
                        price = 1.6;
                        break;
                    case "kiwi":
                        price = 3.0;
                        break;
                    case "pineapple":
                        price = 5.6;
                        break;
                    case "grapes":
                        price = 4.2;
                        break;
                    default:
                        break;
                }
            }

            if (price > 0)
            {
                Console.WriteLine("{0:f2}", price * ammount);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
