using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace exam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bees = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            var hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            var killedHornetsCounter = 0;
            var hornetsWon = false;
            long hornetPowaaa = hornets.Sum();

            for (int i = 0; i < bees.Count; i++)
            {
                long currBeeHive = bees[i];

                if (hornetPowaaa > currBeeHive)
                {
                    bees[i] = 0;
                }
                else if (hornetPowaaa < currBeeHive && hornets.Count > killedHornetsCounter)
                {
                    bees[i] -= hornetPowaaa;
                    hornetPowaaa -= hornets[killedHornetsCounter];
                    hornets[killedHornetsCounter] = 0;
                    killedHornetsCounter++;
                }
                else if (hornetPowaaa == currBeeHive)
                {
                    bees[i] = 0;
                    hornetPowaaa -= hornets[killedHornetsCounter];
                    hornets[killedHornetsCounter] = 0;
                    killedHornetsCounter++;
                }
            }

            if (bees.All(b => b == 0) && hornetPowaaa > 0)
            {
                hornetsWon = true;
            }
            else if (bees.Any(b => b > 0) && hornetPowaaa <= 0)
            {
                hornetsWon = false;
            }

            if (hornetsWon)
            {
                Console.WriteLine(string.Join(" ", hornets.FindAll(h => h > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", bees.FindAll(h => h > 0)));
            }
        }
    }
}
