using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    public class compareChars
    {
        public static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            var firstArray = firstLine.Split(' ').Select(char.Parse).ToArray();
            var secondArray = secondLine.Split(' ').Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    return;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                    return;
                }
                else
                {
                    if (firstArray.Length <= secondArray.Length)
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        return;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        return;
                    }
                }
            }
        }
    }
}
