using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var countryAndCityPop = new Dictionary<string, CityAndPop>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split('|');

                if (input[0] == "report")
                {
                    foreach (var countryitem in countryAndCityPop.OrderByDescending(x => x.Value.TotalPop()))
                    {
                        Console.WriteLine($"{countryitem.Key} (total population: {countryitem.Value.TotalPop()})");
                        foreach (var cityItem in countryitem.Value.CityPop.OrderByDescending(x => x.Value))
                        {
                            Console.WriteLine($"=>{cityItem.Key}: {cityItem.Value}");
                        }
                    }
                    return;
                }

                string country = input[1];
                string city = input[0];
                long population = long.Parse(input[2]);

                if (!countryAndCityPop.ContainsKey(country))
                {
                    countryAndCityPop[country] = new CityAndPop
                    {
                        CityPop = new Dictionary<string, long>()
                    };
                }

                if (!countryAndCityPop[country].CityPop.ContainsKey(city))
                {
                    countryAndCityPop[country].CityPop[city] = population;
                }
            }
        }
    }
}
