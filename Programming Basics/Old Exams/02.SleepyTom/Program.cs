 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());

            int workingDays = 365 - freeDays;

            int playWithTom = (workingDays * 63) + (freeDays * 127);
            int timeLeft = 30000 - playWithTom;

            int hours = Math.Abs(timeLeft / 60);
            int minutes = Math.Abs(timeLeft % 60);

            if (playWithTom <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}
