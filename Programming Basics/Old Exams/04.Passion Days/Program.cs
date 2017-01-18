using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string startStop = Console.ReadLine();
            int purcheses = 0;

            while (startStop != "mall.enter")
            {
                startStop = Console.ReadLine();
            }

            while (true)
            {
                startStop = Console.ReadLine();

                if (startStop == "mall.exit")
                {
                    break;
                }

                int action = int.Parse(startStop);

                if (action >= 65 && action <= 90)
                {
                    if (action <= money)
                    {
                        money -= (action * 0.5M);
                        purcheses++;
                    }
                }
                else if (action >= 97 && action <= 122)
                {
                    if (action <= money)
                    {
                        money -= (action * 0.3M);
                        purcheses++;
                    }
                }
                else if (startStop == "%")
                {
                    money /= 2;
                    purcheses++;
                }
                else if (startStop == "*")
                {
                    money += 10;
                }
            }
            Console.WriteLine(purcheses);
            Console.WriteLine(money);
        }
    }
}
