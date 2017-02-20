using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Count_Work_Days
{
    public class CountWorkDays
    {
        public static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDaysCount = 0;

            var holidaysList = new List<DateTime>
            {
                DateTime.ParseExact("01-01", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12", "dd-MM", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12", "dd-MM", CultureInfo.InvariantCulture),
            };

            bool hasHolidays = false;

            for (; startDate <= endDate; startDate = startDate.AddDays(1))
            {
                if (startDate.DayOfWeek.ToString() == "Saturday" ||
                    startDate.DayOfWeek.ToString() == "Sunday")
                {
                    hasHolidays = true;
                }
                else
                {
                    hasHolidays = false;
                }

                foreach (var date in holidaysList)
                {
                    if (hasHolidays)
                    {
                        break;
                    }
                    else if (date.Day == startDate.Day && date.Month == startDate.Month)
                    {
                        hasHolidays = true;
                        break;
                    }
                    else if (date.Day > startDate.Day && date.Month >= startDate.Month || date.Month > startDate.Month)
                    {
                        break;
                    }
                }
                if (!hasHolidays)
                {
                    workingDaysCount++;
                }
            }

            Console.WriteLine(workingDaysCount);
        }
    }
}
