using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = double.Parse(Console.ReadLine());
            var minute = double.Parse(Console.ReadLine());

            string format = "H:mm";
            DateTime time = new DateTime();
            time = time.AddHours(hour);
            time = time.AddMinutes(minute + 15);

            Console.WriteLine(time.ToString(format));

        }
    }
}
