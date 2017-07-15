using System;
using System.Globalization;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            string[] carInfo = Split(Console.ReadLine());
            string[] truckInfo = Split(Console.ReadLine());
            string[] busInfo = Split(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Vehicle car = new Car(DoubleParse(carInfo[1]), DoubleParse(carInfo[2]), DoubleParse(carInfo[3]));
            Vehicle truck = new Truck(DoubleParse(truckInfo[1]), DoubleParse(truckInfo[2]));
            Vehicle bus = new Bus(DoubleParse(busInfo[1]), DoubleParse(busInfo[2]), DoubleParse(busInfo[3]));

            for (int i = 0; i < n; i++)
            {
                string[] command = Split(Console.ReadLine());

                if (command.First().ToLower() == "drive") // DRIVE
                {
                    double distance = DoubleParse(command.Last());

                    if (command[1].ToLower() == "car") // CAR
                    {
                        Drive(car, distance);
                    }
                    else if (command[1].ToLower() == "truck") // TRUCK
                    {
                        Drive(truck, distance);
                    }
                    else // BUS
                    {
                        Drive(bus, distance);
                    }
                }
                else if (command.First().ToLower() == "driveempty")
                {
                    double distance = DoubleParse(command.Last());

                    try
                    {
                        bus.Drive(distance, 0.0);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else // REFUEL
                {
                    try
                    {
                        if (command[1].ToLower() == "car") // CAR
                        {
                            car.ReFuel(DoubleParse(command[2]));
                        }
                        else if (command[1].ToLower() == "truck") // TRUCK
                        {
                            truck.ReFuel(DoubleParse(command[2]));
                        }
                        else // BUSS
                        {
                            bus.ReFuel(DoubleParse(command[2]));
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            Console.WriteLine($"{car.GetType().Name}: {car.Fuel:f2}");
            Console.WriteLine($"{truck.GetType().Name}: {truck.Fuel:f2}");
            Console.WriteLine($"{bus.GetType().Name}: {bus.Fuel:f2}");
        }

        private static void Drive(Vehicle vehicle, double distance)
        {
            try
            {
                vehicle.Drive(distance);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {distance} km");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string[] Split(string str)
        {
            return str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static double DoubleParse(string str)
        {
            double result;

            double.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out result);

            return result;
        }
    }
}