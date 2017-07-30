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
            int numbersToAdd = int.Parse(Console.ReadLine());
            decimal totalNumbers = 0M;

            for (int counter = 0; counter < numbersToAdd; counter++)
            {
                totalNumbers += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(totalNumbers);
        }
    }
}
