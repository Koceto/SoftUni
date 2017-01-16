using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string vip = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int collums = int.Parse(Console.ReadLine());
            double result = 0.0;

            switch (vip)
            {
                case "premiere":
                    result = row * collums * 12.0;
                    break;
                case "normal":
                    result = row * collums * 7.5;
                    break;
                case "discount":
                    result = row * collums * 5.0;
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0:f2} leva", result);
        }
    }
}
