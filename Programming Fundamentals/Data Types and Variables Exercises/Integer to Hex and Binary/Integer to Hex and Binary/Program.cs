using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = int.Parse(Console.ReadLine()); ;
            string hexValue = intValue.ToString("X");
            string binaryValue = Convert.ToString(intValue, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binaryValue);
        }
    }
}
