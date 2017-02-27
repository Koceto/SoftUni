namespace EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Driver
    {
        public string Name { get; set; }

        public double Fuel { get; set; }

        public int LastStage { get; set; }
    }

    public class Rally
    {
        public static void Main()
        {
            var driverNames = Console.ReadLine()
                .Split(' ');
            var stages = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var checkpoints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var allDrivers = new List<Driver>();

            foreach (var driver in driverNames)
            {
                var currentDriver = new Driver
                {
                    Name = driver,
                    Fuel = driver[0]
                };

                for (int i = 0; i < stages.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        currentDriver.Fuel += stages[i];
                    }
                    else
                    {
                        currentDriver.Fuel -= stages[i];
                    }

                    if (currentDriver.Fuel <= 0)
                    {
                        currentDriver.LastStage = i;
                        break;
                    }
                }
                allDrivers.Add(currentDriver);
            }
            foreach (var driver in allDrivers)
            {
                if (driver.Fuel > 0)
                {
                    Console.WriteLine($"{driver.Name} - fuel left {driver.Fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver.Name} - reached {driver.LastStage}");
                }
            }
        }
    }
}
