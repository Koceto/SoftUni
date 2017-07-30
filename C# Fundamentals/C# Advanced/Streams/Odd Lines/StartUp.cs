using System;
using System.IO;

namespace Odd_Lines
{
    public class StartUp
    {
        public static void Main()
        {
            using (var stream = new StreamReader(Environment.CurrentDirectory + @"\..\..\text.txt"))
            {
                var counter = 0;

                while (true)
                {
                    var line = stream.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(line + Environment.NewLine);
                    }
                    counter++;
                }
            }
        }
    }
}