namespace SinoTheWalker
{
    using System;
    using System.Globalization;

    public class TimeCalculaterForSino
    {
        public static void Main()
        {
            var startingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long stepsNeeded = long.Parse(Console.ReadLine());
            long secondsPerStep = long.Parse(Console.ReadLine());
            var allSeconds = (secondsPerStep * stepsNeeded) % (24 * 60 * 60);
            var result = startingTime.AddSeconds(allSeconds);

            Console.WriteLine("Time Arrival: " + result.ToString("HH:mm:ss"));
        }
    }
}
