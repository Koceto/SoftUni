using System.IO;

namespace Folder_Size
{
    public class FolderSize
    {
        public static void Main()
        {
            var directory = new DirectoryInfo("E:/Users/Коцето/Desktop/Resources/05. Folder Size/TestFolder/");
            double  size = 0.0;

            foreach (var file in directory.GetFiles())
            {
                size += file.Length;
            }

            size = size / 1024;

            File.WriteAllText(directory + "result.txt", size.ToString());
        }
    }
}
