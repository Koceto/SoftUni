using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TileRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            int playgroundWidth = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchHeight = int.Parse(Console.ReadLine());

            int playgroundArea = playgroundWidth * playgroundWidth;
            int benchArea = benchHeight * benchWidth;
            int playgroundAreaToCover = playgroundArea - benchArea;

            double tileArea = tileHeight * tileWidth;
            double tileAmount = playgroundAreaToCover / tileArea;

            double timeToCover = tileAmount * 0.2;

            Console.WriteLine(tileAmount);
            Console.WriteLine(timeToCover);
        }
    }
}
