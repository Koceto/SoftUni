using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Speed_Racing
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> allCars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                string model = data[0];
                double fuel = double.Parse(data[1], CultureInfo.InvariantCulture);
                double fuelPerKilometer = double.Parse(data[2], CultureInfo.InvariantCulture);

                allCars.Add(new Car(model, fuel, fuelPerKilometer));
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(' ');
                string model = data[1];
                int distance = int.Parse(data[2]);
                Car currentCar = allCars.FirstOrDefault(c => c.Model == model);

                if (currentCar != null && !currentCar.Move(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.DistanceTraveled}");
            }
        }
    }
}