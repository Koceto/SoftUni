using System.Collections.Generic;

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