namespace Files
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

    public class Explorer
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var library = new List<File>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var fileData = input
                    .Last()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var root = input[0];
                var fileName = fileData[0];
                var fileSize = long.Parse(fileData[1]);

                var currFile = new File
                {
                    Size = fileSize,
                    Name = fileName,
                    Root = root
                };

                if (library.Any(f => f.Root == root && f.Name == fileName))
                {
                    library.Find(f => f.Name == fileName).Size = fileSize;
                }
                else
                {
                    library.Add(currFile);
                }
            }
            var outputInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var neededExtension = outputInfo.First();
            var neededRoot = outputInfo.Last();
            var anyOutput = false;

            foreach (var file in library.OrderByDescending(f => f.Size).ThenBy(f => f.Name))
            {
                if (file.Name.Split('.').Last() == neededExtension && file.Root == neededRoot)
                {
                    Console.WriteLine($"{file.Name.Trim()} - {file.Size} KB");
                    anyOutput = true;
                }
            }

            if (!anyOutput)
            {
                Console.WriteLine("No");
            }
        }
    }
}
