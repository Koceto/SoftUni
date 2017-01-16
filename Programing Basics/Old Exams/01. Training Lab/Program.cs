using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomHeight = double.Parse(Console.ReadLine());
            double roomWidth = double.Parse(Console.ReadLine());
            roomHeight *= 100;
            roomWidth *= 100;

            roomWidth -= 100;
            int workingSpeceWidth = (int)roomWidth / 70;
            
            int workingSpaceHeight = (int)roomHeight / 120;
            int workingSpace = (workingSpeceWidth * workingSpaceHeight) - 3;

            Console.WriteLine(workingSpace);
        }
    }
}
