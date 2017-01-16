using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            double money = 0;

            if (kilometers < 20)
                money = dayNight.ToLower() == "day" ?
                    money += 0.7 + (kilometers * 0.79) :
                    money += 0.7 + (kilometers * 0.9);

            else if (kilometers < 100)
                money = kilometers * 0.09;
            else
                money = kilometers * 0.06;

            Console.WriteLine(money);
        }
    }
}
