using System.Collections.Generic;

namespace Population_Counter
{
    public class CityAndPop
    {
        public Dictionary<string, long> CityPop { get; set; }

        public long TotalPop()
        {
            long temp = 0;

            foreach (var popNumber in CityPop.Values)
            {
                temp += popNumber;
            }

            return temp;
        }
    }
}
