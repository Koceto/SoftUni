using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stupidCounter = 0;

            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = -n; right <= n; right++)
                    {
                        for (int bottom = -n; bottom <= n; bottom++)
                        {
                            int sideA = right - left;
                            int sideB = top - bottom;

                            if (Math.Abs(sideA * sideB) >= m && left < right && top < bottom)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, Math.Abs(sideA * sideB));
                                stupidCounter++;
                            }
                            else if ((n - (-n)) * (n - (-n)) < m)
                            {
                                Console.WriteLine("No");
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
