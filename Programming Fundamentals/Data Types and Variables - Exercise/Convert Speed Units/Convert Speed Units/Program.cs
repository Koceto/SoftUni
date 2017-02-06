using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float distanceInKilometers = distanceInMeters / 1000;
            float distanceInMiles = distanceInMeters / (float)1609;
            float totalHours = hours + ((((float)seconds / 60) + minutes) / 60);
            float totalMinutes = minutes + ((float)hours * 60) + ((float)seconds / 60);
            float totalSecond = seconds + ((((float)hours * 60) + minutes) * 60);

            //meters per second(m/s)
            Console.WriteLine(distanceInMeters / totalSecond);
            //kilometers per hour(km/h)
            Console.WriteLine(distanceInKilometers / totalHours);
            //miles per hour(mph)
            Console.WriteLine(distanceInMiles / totalHours);
        }
    }
}
