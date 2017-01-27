using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            decimal second = minutes * 60;
            decimal milisecond = second * 1000;
            decimal microsecond = milisecond * 1000;
            decimal nanosecond = microsecond * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {second} seconds = {milisecond} milliseconds = {microsecond} microseconds = {nanosecond} nanoseconds");
        }
    }
}
