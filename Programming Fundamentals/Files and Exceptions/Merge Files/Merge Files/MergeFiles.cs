using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Merge_Files
{
    public class MergeFiles
    {
        public static void Main()
        {
            var filePath = "E:/Users/Коцето/Desktop/Resources/04. Merge Files/";
            var firstFile = File.ReadAllLines(filePath + "FileOne.txt");
            var secondFile = File.ReadAllLines(filePath + "FileTwo.txt");
            
            File.WriteAllLines(filePath + "result.txt", firstFile.Concat(secondFile));
        }
    }
}
