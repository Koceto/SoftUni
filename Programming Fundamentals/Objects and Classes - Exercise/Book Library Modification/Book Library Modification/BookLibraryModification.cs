using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Book_Library_Modification
{
    public class BookLibraryModification
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var library = new Dictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine()
                    .Trim()
                    .Split(' ');
                string title = info[0];
                DateTime releaseDate = DateTime.ParseExact(info[3], "d.MM.yyyy", CultureInfo.InvariantCulture);

                library.Remove(title);
                library.Add(title, releaseDate);

            }
            var date = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(string.Join
                (Environment.NewLine,
                library
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key)
                .SkipWhile(x => x.Value <= date)
                .Select(x => $"{x.Key} -> {x.Value.ToString("d.MM.yyyy")}")));
        }
    }
}
