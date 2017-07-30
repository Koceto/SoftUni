using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    public class Program
    {
        public static void Main()
        {
            string varType = Console.ReadLine();

            if (varType.ToLower() == "int")
            {
                Console.WriteLine(GetMaxInt());
            }
            else if (varType.ToLower() == "string")
            {
                Console.WriteLine(GetMaxString());
            }
            else
            {
                Console.WriteLine(GetMaxChar());
            }
        }

        private static char GetMaxChar()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            
            return (char)Math.Max(first, second);
        }

        private static string GetMaxString()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static int GetMaxInt()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            return Math.Max(first, second);
        }
    }
}
