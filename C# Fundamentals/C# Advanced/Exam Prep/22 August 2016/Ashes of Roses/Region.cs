using System.Collections.Generic;

namespace Ashes_of_Roses
{
    public class Region
    {
        public string Name { get; set; }

        public List<Color> Colors { get; set; }

        public decimal TotalRoses()
        {
            decimal temp = 0M;

            foreach (var color in Colors)
            {
                temp += color.Ammount;
            }

            return temp;
        }
    }
}