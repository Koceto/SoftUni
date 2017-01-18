using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int answerA = 0;
            int answerB = 0;
            int answerC = 0;
            int answerD = 0;
            string answers = string.Empty;

            for (long i = 0; i < n; i++)
            {
                long num = long.Parse(Console.ReadLine());

                if (num % 4 == 0)
                {
                    answerA++;
                    answers += "a ";
                }
                else if (num % 4 == 1)
                {
                    answerB++;
                    answers += "b ";
                }
                else if (num % 4 == 2)
                {
                    answerC++;
                    answers += "c ";
                }
                else
                {
                    answerD++;
                    answers += "d ";
                }
            }

            Console.WriteLine(answers);
            Console.WriteLine("Answer A: {0}", answerA);
            Console.WriteLine("Answer B: {0}", answerB);
            Console.WriteLine("Answer C: {0}", answerC);
            Console.WriteLine("Answer D: {0}", answerD);
        }
    }
}
