namespace Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class MotherTrucker
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var truckFuel = default(decimal);
            var startingStation = 0;

            for (int i = 0; i < n; i++)
            {
                var currStation = Console.ReadLine()
                    .Trim()
                    .Split(' ')
                    .Select(decimal.Parse)
                    .ToArray();

                var station = currStation.First() - currStation.Last();

                truckFuel += station;

                if (truckFuel < 0)
                {
                    truckFuel = 0;
                    startingStation = i + 1;
                }
            }

            Console.WriteLine(startingStation);
        }
    }
}
