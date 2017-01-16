using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double work = double.Parse(Console.ReadLine());
            double payment = 0.0;

            if (work >= 0 && work <= 500)
            {
                switch (city)
                {
                    case "sofia":
                        payment = work * 0.05;
                        break;
                    case "varna":
                        payment = work * 0.045;
                        break;
                    case "plovdiv":
                        payment = work * 0.055;
                        break;
                    default:
                        break;
                }
            }
            else if (work > 500 && work <= 1000)
            {
                switch (city)
                {
                    case "sofia":
                        payment = work * 0.07;
                        break;
                    case "varna":
                        payment = work * 0.075;
                        break;
                    case "plovdiv":
                        payment = work * 0.08;
                        break;
                    default:
                        break;
                }
            }
            else if (work > 1000 && work <= 10000)
            {
                switch (city)
                {
                    case "sofia":
                        payment = work * 0.08;
                        break;
                    case "varna":
                        payment = work * 0.10;
                        break;
                    case "plovdiv":
                        payment = work * 0.12;
                        break;
                    default:
                        break;
                }
            }
            else if (work > 10000)
            {
                switch (city)
                {
                    case "sofia":
                        payment = work * 0.12;
                        break;
                    case "varna":
                        payment = work * 0.13;
                        break;
                    case "plovdiv":
                        payment = work * 0.145;
                        break;
                    default:
                        break;
                }
            }
            if (payment > 0)
            {
                Console.WriteLine("{0:f2}", payment);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
