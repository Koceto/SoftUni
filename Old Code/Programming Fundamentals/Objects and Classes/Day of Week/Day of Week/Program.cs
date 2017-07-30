using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Day_of_Week
{
    public class DayofWeek
    {
        public static void Main()
        {
            DateTime time = DateTime.ParseExact(
                Console.ReadLine(),
                "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(time.DayOfWeek);
        }
    }
}
