using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180117_Lectures
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * r * r;

            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
