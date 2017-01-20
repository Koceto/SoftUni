using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            //sbyte < byte < short < ushort < int < uint < long
            sbyte sbyteTrash = 0;
            bool dataSbyte = sbyte.TryParse(number, out sbyteTrash);

            byte byteTrash = 0;
            bool dataByte = byte.TryParse(number, out byteTrash);

            short shortTrash = 0;
            bool dataShort = short.TryParse(number, out shortTrash);

            ushort ushortTrash = 0;
            bool dataUshort = ushort.TryParse(number, out ushortTrash);

            int intTrash = 0;
            bool dataInt = int.TryParse(number, out intTrash);

            uint uintTrash = 0;
            bool dataUint = uint.TryParse(number, out uintTrash);

            long longTrash = 0;
            bool datalong = long.TryParse(number, out longTrash);
            
            if (!dataSbyte && !dataByte && !dataShort && !dataUshort && !dataInt && !dataUint && !datalong)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{number} can fit in:");
            }
            if (dataSbyte)
            {
                Console.WriteLine("* sbyte");
            }
            if (dataByte)
            {
                Console.WriteLine("* byte");
            }
            if (dataShort)
            {
                Console.WriteLine("* short");
            }
            if (dataUshort)
            {
                Console.WriteLine("* ushort");
            }
            if (dataInt)
            {
                Console.WriteLine("* int");
            }
            if (dataUint)
            {
                Console.WriteLine("* uint");
            }
            if (datalong)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
