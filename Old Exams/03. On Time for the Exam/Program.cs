using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int studentTime = hourOfArrival * 60 + minuteOfArrival;

            if (examTime - studentTime > 30)
            {
                Console.Write("Early ");
                if (examTime - studentTime >= 60)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", (examTime - studentTime) / 60, (examTime - studentTime) % 60);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", examTime - studentTime);
                }
            }
            else if (examTime - studentTime >= 0 && examTime - studentTime <= 30)
            {
                Console.Write("On time ");
                Console.WriteLine("{0} minutes before the start", examTime - studentTime);
            }
            else
            {
                Console.Write("Late ");
                if (studentTime - examTime >= 60)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", (studentTime - examTime) / 60, (studentTime - examTime) % 60);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", studentTime - examTime);
                }
            }
        }
    }
}
