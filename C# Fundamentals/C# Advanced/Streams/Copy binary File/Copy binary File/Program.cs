﻿using System.Text;

namespace Copy_binary_File
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new FileStream("../../earth.jpg", FileMode.Open, FileAccess.Read))
            {
                using (var writer = new FileStream("../../result.jpg", FileMode.Create, FileAccess.Write))
                {
                    while (true)
                    {
                        var buffer = new byte[1024];
                        int readBytes = reader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
