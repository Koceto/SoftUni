namespace FilesTheSecond
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class File
    {
        public string Root { get; set; }

        public string Name { get; set; }

        public long Size { get; set; }
    }

    public class Files
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var allFiles = new List<File>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var rootIndex = input.IndexOf('\\');
                var fileIndex = input.LastIndexOf('\\');
                var fileInfo = input.Substring(fileIndex + 1, input.Length - 1 - fileIndex);
                var rootDir = input.Substring(0, rootIndex);
                var size = long.Parse(fileInfo.Split(';').Last());
                var name = fileInfo.Split(';').First();

                if (allFiles.Any(f => f.Root == rootDir && f.Name == name))
                {
                    allFiles.Find(f => f.Name == name).Size = size;
                }
                else
                {
                    allFiles.Add(new File
                    {
                        Root = rootDir,
                        Name = name,
                        Size = size
                    });
                }
            }
            var command = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var extension = command.First();
            var root = command.Last();
            var anyFile = default(bool);

            foreach (var file in allFiles.OrderByDescending(f => f.Size).ThenBy(f => f.Name))
            {
                var ext = file.Name.Split('.').Last();

                if (file.Root == root && ext == extension)
                {
                    Console.WriteLine($"{file.Name} - {file.Size} KB");
                    anyFile = true;
                }
            }

            if (!anyFile)
            {
                Console.WriteLine("No");
            }
        }
    }
}
