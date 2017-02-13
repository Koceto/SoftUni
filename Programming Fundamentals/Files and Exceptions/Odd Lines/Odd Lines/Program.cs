using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Odd_Lines
{
    public class OddLines
    {
        public static void Main()
        {
            var file = "E:/Users/Коцето/Desktop/Resources/01. Odd Lines/input.txt";
            var lines = File.ReadAllLines(file);
            var sortedOutput = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sortedOutput.Add(lines[i]);
                }
            }

            File.WriteAllLines("E:/Users/Коцето/Desktop/Resources/01. Odd Lines/result.txt", sortedOutput);
        }
    }
}
