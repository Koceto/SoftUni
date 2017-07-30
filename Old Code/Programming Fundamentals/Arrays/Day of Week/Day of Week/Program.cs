using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    public class numberToDay
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var day = new string[7];
            day[0] = "Monday";
            day[1] = "Tuesday";
            day[2] = "Wednesday";
            day[3] = "Thursday";
            day[4] = "Friday";
            day[5] = "Saturday";
            day[6] = "Sunday";

            if (n <= 0 || n > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(day[n - 1]);
            }
        }
    }
}
