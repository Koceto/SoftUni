using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToWrite = int.Parse(Console.ReadLine());
            int result = 0;

            for (int write = 0; write < timesToWrite; write++)
            {
                int toAdd = int.Parse(Console.ReadLine());
                result += toAdd;
            }
            Console.WriteLine(result);
        }
    }
}
