using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte dataSbyte = sbyte.Parse(Console.ReadLine());
            byte dataByte = byte.Parse(Console.ReadLine());
            short dataShort = short.Parse(Console.ReadLine());
            ushort dataUshort = ushort.Parse(Console.ReadLine());
            uint dataUint = uint.Parse(Console.ReadLine());
            int dataInt = int.Parse(Console.ReadLine());
            long dataLong = long.Parse(Console.ReadLine());

            Console.WriteLine(dataSbyte);
            Console.WriteLine(dataByte);
            Console.WriteLine(dataShort);
            Console.WriteLine(dataUshort);
            Console.WriteLine(dataUint);
            Console.WriteLine(dataInt);
            Console.WriteLine(dataLong);
        }
    }
}
