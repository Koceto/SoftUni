namespace PopulationAggregation
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Country
    {
        public string Name { get; set; }

        public int Cities { get; set; }
    }

    public class City
    {
        public string Name { get; set; }

        public long Population { get; set; }
    }

    public class Peeps
    {
        public static void Main()
        {
            var regex = new Regex(@"[@|#|$|&|0-9]");
            var allCountries = new List<Country>();
            var allCities = new List<City>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                if (input.First().ToLower() == "stop")
                {
                    break;
                }

                var first = regex.Replace(input[0], string.Empty);
                var second = regex.Replace(input[1], string.Empty);

                var countryName = char.IsUpper(first[0]) ? first : second;
                var cityName = char.IsUpper(first[0]) ? second : first;
                var population = long.Parse(input.Last());

                var currCity = new City
                {
                    Name = cityName,
                    Population = population
                };

                if (!allCountries.Any(c => c.Name == countryName))
                {
                    allCountries.Add(new Country
                    {
                        Name = countryName,
                        Cities = 0
                    });
                }

                if (!allCities.Any(c => c.Name == cityName))
                {
                    allCities.Add(new City
                    {
                        Name = cityName,
                        Population = population
                    });
                }
                else if (allCities.Any(c => c.Name == cityName))
                {
                    allCities.Find(c => c.Name == cityName).Population = population;
                }

                allCountries.Find(c => c.Name == countryName).Cities++;
            }

            foreach (var country in allCountries.OrderBy(c => c.Name))
            {
                Console.WriteLine($"{country.Name} -> {country.Cities}");
            }

            foreach (var city in allCities.OrderByDescending(c => c.Population).Take(3))
            {
                Console.WriteLine($"{city.Name} -> {city.Population}");
            }
        }
    }
}
