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
            int peopleToElevate = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            double elevatorTrips = Math.Ceiling(peopleToElevate * 1.0 / elevatorCapacity);

            Console.WriteLine(elevatorTrips);
        }
    }
}
