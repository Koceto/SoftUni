using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricksCount = int.Parse(Console.ReadLine());
            int workingForce = int.Parse(Console.ReadLine());
            int dollyCapacity = int.Parse(Console.ReadLine());

            double combinedForce = workingForce * dollyCapacity;

            Console.WriteLine("{0}", Math.Ceiling(bricksCount / combinedForce));
        }
    }
}
