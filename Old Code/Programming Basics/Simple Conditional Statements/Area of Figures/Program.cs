using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = Console.ReadLine();

            if (form == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a*a);
            }
            else if (form == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a*b);
            }
            else if (form == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                var pi = Math.PI;
                Console.WriteLine(Math.Round((pi*a*a),3));
            }
            else if (form == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(((a*b)/2),3));
            }
        }
    }
}
