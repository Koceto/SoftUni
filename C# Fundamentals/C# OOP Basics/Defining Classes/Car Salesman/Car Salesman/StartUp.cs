using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Salesman
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> listOfEngines = new List<Engine>();
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                int displacement;
                string efficiency;
                Engine engine;

                if (engineInfo.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out displacement))
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                        engine = new Engine(model, power, efficiency);
                    }
                }
                else
                {
                    displacement = int.Parse(engineInfo[2]);
                    efficiency = engineInfo[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }

                listOfEngines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                Engine engine = listOfEngines.First(e => e.Model == carInfo[1]);
                int weight;
                string color;
                Car car;

                if (carInfo.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out weight))
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        color = carInfo[2];
                        car = new Car(model, engine, color);
                    }
                }
                else
                {
                    weight = int.Parse(carInfo[2]);
                    color = carInfo[3];
                    car = new Car(model, engine, weight, color);
                }

                listOfCars.Add(car);
            }

            foreach (var car in listOfCars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}