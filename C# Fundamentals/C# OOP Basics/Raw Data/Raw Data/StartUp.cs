using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Raw_Data
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(n);

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                string model = data[0];
                Engine engine = new Engine(int.Parse(data[1]), int.Parse(data[2]));
                Cargo cargo = new Cargo(int.Parse(data[3]), data[4]);
                List<Tire> tires = new List<Tire>();
                tires.Add(new Tire(double.Parse(data[5], CultureInfo.InvariantCulture), int.Parse(data[6])));
                tires.Add(new Tire(double.Parse(data[7], CultureInfo.InvariantCulture), int.Parse(data[8])));
                tires.Add(new Tire(double.Parse(data[9], CultureInfo.InvariantCulture), int.Parse(data[10])));
                tires.Add(new Tire(double.Parse(data[11], CultureInfo.InvariantCulture), int.Parse(data[12])));

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string toPrint = Console.ReadLine().Trim().ToLower();

            if (toPrint == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == toPrint && c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == toPrint && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}