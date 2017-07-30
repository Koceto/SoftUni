using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            var pi = Math.PI;

            var dagrees = Math.Round((radians * 180) / pi);
            Console.WriteLine(dagrees);
        }
    }
}
