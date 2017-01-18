using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;
            string placeToSleep = string.Empty;

            if (budget <= 100)
            {
                if (season.ToLower() == "summer")
                {
                    budget *= 0.3M;
                    destination = "Bulgaria";
                    placeToSleep = "Camp";
                }
                else
                {
                    destination = "Bulgaria";
                    budget *= 0.7M;
                    placeToSleep = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                if (season.ToLower() == "summer")
                {
                    budget *= 0.4M;
                    destination = "Balkans";
                    placeToSleep = "Camp";
                }
                else
                {
                    destination = "Balkans";
                    budget *= 0.8M;
                    placeToSleep = "Hotel";
                }
            }
            else
            {
                budget *= 0.9M;
                destination = "Europe";
                placeToSleep = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", placeToSleep, budget);
        }
    }
}
