using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPoint = int.Parse(Console.ReadLine());
            int secondPoint = int.Parse(Console.ReadLine());
            int thePoint = int.Parse(Console.ReadLine());

            int firstPointCopy = firstPoint;
            int secondPointCopy = secondPoint;

            if (secondPoint < firstPoint)
            {
                firstPoint = secondPointCopy;
                secondPoint = firstPointCopy;
            }

            if (thePoint >= firstPoint && thePoint <= secondPoint)
            {
                Console.WriteLine("in");
                Console.WriteLine("{0}", thePoint - firstPoint <= secondPoint - thePoint ?
                    thePoint - firstPoint :
                    secondPoint - thePoint);
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine("{0}", Math.Abs(firstPoint - thePoint) <= Math.Abs(thePoint - secondPoint) ?
                    firstPoint - thePoint :
                    thePoint - secondPoint);
            }

        }
    }
}
