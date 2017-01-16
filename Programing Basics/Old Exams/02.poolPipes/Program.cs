using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.poolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hoursLeftUnatended = double.Parse(Console.ReadLine());
            double totalPipeVolumeFilled = (pipeOne + pipeTwo) * hoursLeftUnatended;

            if (totalPipeVolumeFilled <= poolVolume)
            {
                double pipeOneFilled = pipeOne * hoursLeftUnatended;
                double pipeTwoFilled = pipeTwo * hoursLeftUnatended;

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    (int)((totalPipeVolumeFilled / poolVolume) * 100),
                    (int)(pipeOneFilled / totalPipeVolumeFilled * 100),
                    (int)(pipeTwoFilled / totalPipeVolumeFilled * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                    hoursLeftUnatended,
                    (totalPipeVolumeFilled - poolVolume));
            }
        }
    }
}
