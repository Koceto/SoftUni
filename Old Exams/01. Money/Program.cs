using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double chineseYuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            bitcoin = bitcoin * 1168;
            chineseYuan = chineseYuan * 0.15;
            chineseYuan = chineseYuan * 1.76;
            double euro = (chineseYuan + bitcoin) / 1.95;
            euro = euro - euro * (commision / 100);

            Console.WriteLine(euro);
        }
    }
}
