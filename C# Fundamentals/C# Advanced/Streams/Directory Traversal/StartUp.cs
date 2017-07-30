using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    public class StartUp
    {
        public static void Main()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var folder = Environment.SystemDirectory;
            var allFiles = new Dictionary<string, List<FileBunny>>();

            foreach (var currFile in Directory.GetFiles(folder))
            {
                var fileInfo = new FileInfo(currFile);
                var fileName = fileInfo.Name;
                var fileExtension = fileInfo.Extension;
                var fileSizeInKB = fileInfo.Length / 1024.0;

                if (allFiles.ContainsKey(fileExtension))
                {
                    allFiles[fileExtension].Add(new FileBunny()
                    {
                        Name = fileName,
                        Size = fileSizeInKB
                    });
                }
                else
                {
                    allFiles.Add(fileExtension, new List<FileBunny>());
                    allFiles[fileExtension].Add(new FileBunny()
                    {
                        Name = fileName,
                        Size = fileSizeInKB
                    });
                }
            }

            using (var writer = new StreamWriter($"{desktop}/report.txt"))
            {
                foreach (var fileBunny in allFiles.OrderByDescending(f => f.Value.Count).ThenBy(f => f.Key))
                {
                    writer.WriteLine(fileBunny.Key);

                    foreach (var file in fileBunny.Value.OrderBy(f => f.Size))
                    {
                        writer.WriteLine($"--{file.Name} - {file.Size:f3}kb");
                    }
                }
            }
        }
    }
}