using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    public class Program
    {
        public static void Main()
        {
            string firstNumbers = Console.ReadLine();
            string secondNumbers = Console.ReadLine();

            var firstArray = firstNumbers.Split(' ').Select(int.Parse).ToArray();
            var secondArray = secondNumbers.Split(' ').Select(int.Parse).ToArray();
            
            int longerArray = Math.Max(firstArray.Length, secondArray.Length);
            var resultArray = new int[longerArray];

            for (int i = 0; i < longerArray; i++)
            {
                resultArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
