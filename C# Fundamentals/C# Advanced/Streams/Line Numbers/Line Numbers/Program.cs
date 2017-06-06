namespace Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var text = new Queue<String>();

            using (var reader = new StreamReader(Environment.CurrentDirectory + @"/../../text.txt"))
            {
                while (true)
                {
                    var line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    text.Enqueue(line);
                }
            }

            using (var writer = new StreamWriter(Environment.CurrentDirectory + @"/../../text.txt"))
            {
                var counter = 1;

                while (text.Count > 1)
                {
                    writer.WriteLine("{0}. {1}", counter, text.Dequeue());
                    counter++;
                }
            }
        }
    }
}
