using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int charCount = int.Parse(Console.ReadLine());

            for (char firstChar = 'a'; firstChar < 'a' + charCount; firstChar++)
            {
                for (char secondChar = 'a'; secondChar < 'a' + charCount; secondChar++)
                {
                    for (char thirdChar = 'a'; thirdChar < 'a' + charCount; thirdChar++)
                    {
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
