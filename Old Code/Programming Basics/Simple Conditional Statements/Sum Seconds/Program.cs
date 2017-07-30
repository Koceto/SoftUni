using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            DateTime sum = new DateTime().AddSeconds(a+b+c);

            string format = "m:ss";

            Console.WriteLine(sum.ToString(format));
        }
    }
}
