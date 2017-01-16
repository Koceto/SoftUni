using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = 1;
            double mToMm = 1000;
            double mToCm = 100;
            double mToMi = 0.000621371192;
            double mToIn = 39.3700787;
            double mToKm = 0.001;
            double mToFt = 3.2808399;
            double mToYd = 1.0936133;

            double distance = Double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            if (from == "mm")
            {
                distance = distance / mToMm;
            }
            else if (from == "cm")
            {
                distance = distance / mToCm;
            }
            else if (from == "mi")
            {
                distance = distance / mToMi;
            }
            else if (from == "in")
            {
                distance = distance / mToIn;
            }
            else if (from == "km")
            {
                distance = distance / mToKm;
            }
            else if (from == "ft")
            {
                distance = distance / mToFt;
            }
            else if (from == "yd")
            {
                distance = distance / mToYd;
            }

            if (to == "mm")
            {
                distance = distance * mToMm;
            }
            else if (to == "cm")
            {
                distance = distance * mToCm;
            }
            else if (to == "mi")
            {
                distance = distance * mToMi;
            }
            else if (to == "in")
            {
                distance = distance * mToIn;
            }
            else if (to == "km")
            {
                distance = distance * mToKm;
            }
            else if (to == "ft")
            {
                distance = distance * mToFt;
            }
            else if (to == "yd")
            {
                distance = distance * mToYd;
            }
            Console.WriteLine(distance);
        }
    }
}
