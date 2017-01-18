using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int holiday = int.Parse(Console.ReadLine());
            int backHome = int.Parse(Console.ReadLine());
            double gamesInSofia = (48 - backHome) * (3.0/4);
            double gamesDuringHolidays = holiday * (2.0/3);
            double result = 0;

            if (year == "leap")
            {
                result = (gamesInSofia + gamesDuringHolidays + backHome) * 1.15;
            }
            else
            {
                result = gamesInSofia + gamesDuringHolidays + backHome;
            }
            Console.WriteLine(Math.Truncate(result));
        }
    }
}
