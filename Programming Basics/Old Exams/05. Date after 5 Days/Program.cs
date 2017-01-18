using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string month = string.Empty;
            string day = string.Empty;

            if (d < 10)
            {
                day = d.ToString("0" + d);
            }
            else
            {
                day = d.ToString();
            }
            if (m < 10)
            {
                month = m.ToString("0" + m);
            }
            else
            {
                month = d.ToString();
            }

            string date = day + month;

            DateTime dateBefore = DateTime.ParseExact(date, "MM.dd", null);
            DateTime dateAfter = dateBefore.AddDays(5);

            string currDate = dateAfter.ToString(string.Format("{0:##}.{1:00}", "dd", "MM"));
            

            Console.WriteLine(currDate);
        }
    }
}
