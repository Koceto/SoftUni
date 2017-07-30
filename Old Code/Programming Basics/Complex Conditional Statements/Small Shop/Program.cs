using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string stock = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;

            switch (stock)
            {
                case "coffee":
                    switch (city)
                    {
                        case "sofia":
                            price = 0.5;
                            break;
                        case "plovdiv":
                            price = 0.4;
                            break;
                        case "varna":
                            price = 0.45;
                            break;
                        default:
                            break;
                    }
                    break;
                case "water":
                    switch (city)
                    {
                        case "sofia":
                            price = 0.8;
                            break;
                        case "plovdiv":
                            price = 0.7;
                            break;
                        case "varna":
                            price = 0.7;
                            break;
                        default:
                            break;
                    }

                    break;
                case "beer":
                    switch (city)
                    {
                        case "sofia":
                            price = 1.2;
                            break;
                        case "plovdiv":
                            price = 1.15;
                            break;
                        case "varna":
                            price = 1.10;
                            break;
                        default:
                            break;
                    }

                    break;
                case "sweets":
                    switch (city)
                    {
                        case "sofia":
                            price = 1.45;
                            break;
                        case "plovdiv":
                            price = 1.3;
                            break;
                        case "varna":
                            price = 1.35;
                            break;
                        default:
                            break;
                    }

                    break;
                case "peanuts":
                    switch (city)
                    {
                        case "sofia":
                            price = 1.6;
                            break;
                        case "plovdiv":
                            price = 1.5;
                            break;
                        case "varna":
                            price = 1.55;
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }
            Console.WriteLine(quantity * price);
        }
    }
}
