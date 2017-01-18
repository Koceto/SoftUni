using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int compare = 0;
            int result = 0;
            int resultBackUp = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > compare)
                {
                    result++;
                    if (result >= resultBackUp)
                    {
                        resultBackUp = result;
                    }
                }
                else
                {
                    result = 1;
                }

                compare = num;
            }
            Console.WriteLine(resultBackUp);
        }
    }
}
