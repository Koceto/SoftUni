using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePricePerKilo = double.Parse(Console.ReadLine());
            double fruitPricePerKilo = double.Parse(Console.ReadLine());
            int totalVegetables = int.Parse(Console.ReadLine());
            int totalFruit = int.Parse(Console.ReadLine());

            double totalVegetablePrice = vegetablePricePerKilo * totalVegetables;
            double totalFruitPrice = fruitPricePerKilo * totalFruit;

            double totalEarnings = (totalVegetablePrice + totalFruitPrice) / 1.94;

            Console.WriteLine("{0}",totalEarnings);
        }
    }
}
