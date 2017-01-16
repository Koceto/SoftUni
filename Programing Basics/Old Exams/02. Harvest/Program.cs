using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerSquareMeter = double.Parse(Console.ReadLine());
            int requiredLitersOfWine = int.Parse(Console.ReadLine());
            int workingForce = int.Parse(Console.ReadLine());

            double grapesHarvested = area * grapesPerSquareMeter;
            double grapesForWine = grapesHarvested * 0.4;
            double wineProduced = grapesForWine / 2.5;

            if (wineProduced >= requiredLitersOfWine)
            {
                double wine = wineProduced - requiredLitersOfWine;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                    Math.Floor(wineProduced));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(wine),
                    Math.Ceiling(wine / workingForce));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                    Math.Floor(requiredLitersOfWine - wineProduced));
            }
        }
    }
}
