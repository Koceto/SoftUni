using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inch_to_sm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inch: ");
            var inch = double.Parse(Console.ReadLine());
            var sm = inch * 2.54;
            Console.WriteLine("Sm: {0}", sm);
        }
    }
}