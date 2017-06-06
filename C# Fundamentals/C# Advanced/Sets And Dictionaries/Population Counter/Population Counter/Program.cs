using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    using System;

    public class CityAndPopulation
    {
        public string CityName { get; set; }

        public long Population { get; set; }
    }

    public class Country
    {
        public string CountryName { get; set; }

        public List<CityAndPopulation> Cities { get; set; }

        public decimal TotalPopulation
        {
            get
            {
                var temp = 0M;

                foreach (var cityAndPopulation in Cities)
                {
                    temp += cityAndPopulation.Population;
                }

                return temp;
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            var countries = new List<Country>();

            while (true)
            {
                var input = Console.ReadLine().Trim().Split('|');

                if (input.First().ToLower() == "report")
                {
                    GenerateReport(countries);
                    return;
                }

                var currCountry = input[1];
                var currCity = input.First();
                var currPopulation = long.Parse(input.Last());

                if (countries.All(c => c.CountryName != currCountry))
                {
                    countries.Add(new Country()
                    {
                        CountryName = currCountry,

                        Cities = new List<CityAndPopulation>()
                        {
                            new CityAndPopulation()
                            {
                                CityName = currCity,
                                Population = currPopulation
                            }
                        }
                    });
                }
                else
                {
                    countries
                        .Find(c => c.CountryName == currCountry)
                        .Cities
                        .Add(new CityAndPopulation()
                        {
                            CityName = currCity,
                            Population = currPopulation
                        });
                }
            }
        }

        private static void GenerateReport(List<Country> countries)
        {
            foreach (var country in countries.OrderByDescending(c => c.TotalPopulation))
            {
                Console.WriteLine($"{country.CountryName} (total population: {country.TotalPopulation})");

                foreach (var cityPopulation in country.Cities.OrderByDescending(c => c.Population))
                {
                    Console.WriteLine($"=>{cityPopulation.CityName}: {cityPopulation.Population}");
                }
            }
        }
    }
}