using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.smartZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int lillysAge = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int money = 0;
            int toys = 0;
            int moreMoney = 0;
            int stolenMoney = 0;

            for (int i = 1; i <= lillysAge; i++)
            {
                if (i % 2 == 0)
                {
                    moreMoney += 10;
                    money += moreMoney;
                    stolenMoney++;
                }
                else
                {
                    toys++;
                }
            }
            money = money - stolenMoney + (toys * toyPrice);

            if (money >= machinePrice)
            {
                Console.WriteLine("Yes! {0:0.00}", (money - machinePrice));
            }
            else
            {
                Console.WriteLine("No! {0:0.00}", (machinePrice - money));
            }
        }
    }
}
