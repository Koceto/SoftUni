using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distancePer1000 = double.Parse(Console.ReadLine());
            var wingFlapsForBrake = int.Parse(Console.ReadLine());    //break is 5 seconds
            // 100 flaps/s

            var totalDistance = (wingFlaps / 1000) * distancePer1000;
            var seconds = (wingFlaps / 100) + ((wingFlaps / wingFlapsForBrake) * 5);

            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
