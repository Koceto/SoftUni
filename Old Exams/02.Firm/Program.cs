using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeRequired = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int workingPersonale = int.Parse(Console.ReadLine());

            double actuallDays = availableDays - (availableDays * 0.1);
            double overTime = workingPersonale * (availableDays * 2);
            double workingHours = actuallDays * 8;
            double totalTimeAvailable = Math.Floor(workingHours + overTime);

            if (totalTimeAvailable >= timeRequired)
            {
                Console.WriteLine("Yes!{0} hours left.", totalTimeAvailable - timeRequired);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", timeRequired - totalTimeAvailable);
            }
        }
    }
}
