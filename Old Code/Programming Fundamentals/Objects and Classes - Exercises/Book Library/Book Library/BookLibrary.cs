using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Library
{
    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var authors = new Dictionary<string, Library>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');
                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.Parse(input[3]);
                int isbn = int.Parse(input[4]);
                decimal price = decimal.Parse(input[5]);

                if (!authors.ContainsKey(input[1]))
                {
                    authors[input[1]] = new Library
                    {
                        Title = new List<string>(),
                        Publisher = new List<string>(),
                        ReleaseDate = new List<DateTime>(),
                        ISBN = new List<int>(),
                        Price = new List<decimal>()
                    };
                };
                authors[input[1]].Title.Add(title);
                authors[input[1]].Publisher.Add(publisher);
                authors[input[1]].ReleaseDate.Add(releaseDate);
                authors[input[1]].ISBN.Add(isbn);
                authors[input[1]].Price.Add(price);

            }

            Console.WriteLine(string.Join
                (Environment.NewLine,
                authors
                .OrderByDescending(x => x.Value.Price.Sum())
                .ThenBy(x => x.Key)
                .Select(x => $"{x.Key} -> {x.Value.Price.Sum():f2}")));
        }
    }
}
