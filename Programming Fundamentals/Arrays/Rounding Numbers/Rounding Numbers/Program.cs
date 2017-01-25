using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    public class rounding
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            var roundArray = numbers.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < roundArray.Length; i++)
            {
                Console.WriteLine(roundArray[i]);
                roundArray[i] = Math.Round(roundArray[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(roundArray[i]);
            }
        }
    }
}
