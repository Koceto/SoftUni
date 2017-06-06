using System.IO;
using System.IO.Compression;

namespace Zipping_Sliced_Files
{
    public class Program
    {
        public const string FileName = "video.mp4"; // Choose File
        public const string Folder = "../../";

        public static void Main()
        {
            using (var reader = new FileStream($"{Folder}{FileName}", FileMode.Open, FileAccess.Read))
            {
                using (var writer = new FileStream($"{Folder}{FileName}.gz", FileMode.Create, FileAccess.Write))
                {
                    using (var compressStream = new GZipStream(writer, CompressionMode.Compress))
                    {
                        while (true)
                        {
                            var buffer = new byte[4096];
                            int readBytes = reader.Read(buffer, 0, buffer.Length);

                            if (readBytes == 0)
                            {
                                break;
                            }

                            compressStream.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
    }
}
