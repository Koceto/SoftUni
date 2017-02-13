using System;
using System.IO;

namespace Line_Numbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var file = "E:/Users/Коцето/Desktop/Resources/02. Line Numbers/input.txt";
            var lines = File.ReadAllLines(file);
            var result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = $"{i + 1}. {lines[i]}";
            }
            
            File.WriteAllLines("E:/Users/Коцето/Desktop/Resources/02. Line Numbers/result.txt", result);
        }
    }
}
