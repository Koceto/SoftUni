using System;
using System.IO;

namespace SlicingFile
{
    public static class Program
    {
        public const string FileToSlice = "video"; // Choose file
        public const string FileToSliceExtension = "mp4"; // Choose the correct File Extension
        public const string Folder = "../../";
        public const int Parts = 5; // Total parts

        public static void Main(string[] args)
        {
            Slice();
            Assemble();
        }

        public static void Slice()
        {
            using (var fileReader = new FileStream($"{Folder}{FileToSlice}.{FileToSliceExtension}", FileMode.Open, FileAccess.Read))
            {
                var length = fileReader.Length;
                var partSize = length / Parts;
                var buffer = new byte[partSize];

                for (int i = 1; i <= Parts; i++)
                {
                    using (var fileWriter = new FileStream($"{Folder}{FileToSlice}-part{i}.{FileToSliceExtension}", FileMode.Create, FileAccess.Write))
                    {
                        var number = fileReader.Read(buffer, 0, buffer.Length);

                        fileWriter.Write(buffer, 0, number);
                    }
                    Console.WriteLine($"Created file {FileToSlice}-part{i}.{FileToSliceExtension}");
                }
            }
            Console.WriteLine("Done slicing.");
        }

        public static void Assemble()
        {
            var buffer = new byte[4096];

            using (var assembler = new FileStream($"{Folder}{FileToSlice}.{FileToSliceExtension}", FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < Parts; i++)
                {
                    using (var partsReader = new FileStream($"{Folder}{FileToSlice}-part{i + 1}.{FileToSliceExtension}", FileMode.Open, FileAccess.Read))
                    {
                        var number = default(int);

                        while ((number = partsReader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            assembler.Write(buffer, 0, number);
                        }
                    }
                }
            }
            Console.WriteLine($"File {FileToSlice}.{FileToSliceExtension} Reassembled");
        }
    }
}