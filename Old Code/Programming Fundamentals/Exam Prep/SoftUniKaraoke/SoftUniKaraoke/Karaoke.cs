namespace SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Signer
    {
        public string Name { get; set; }

        public HashSet<string> Awards { get; set; }

        public int NumOfAwards()
        {
            return Awards.Count();
        }
    }

    public class Karaoke
    {
        public static void Main(string[] args)
        {
            var people = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();
            var participants = new List<Signer>();
            var isAwards = false;

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToArray();
                if (input[0] == "dawn")
                {
                    foreach (var signer in participants.OrderByDescending(x => x.NumOfAwards()).ThenBy(x => x.Name))
                    {
                        isAwards = true;

                        Console.WriteLine($"{signer.Name}: {signer.NumOfAwards()} awards");

                        foreach (var award in signer.Awards.OrderBy(x => x))
                        {
                            Console.WriteLine($"--{award}");
                        }
                    }
                    if (!isAwards)
                    {
                        Console.WriteLine("No awards");
                    }
                    return;
                }

                var song = input[1];
                var currPerformer = new Signer
                {
                    Name = input[0],
                    Awards = new HashSet<string>()
                };

                currPerformer.Awards.Add(input[2]);

                if (people.Contains(input[0]))
                {
                    if (songs.Any(x => x == song))
                    {
                        if (participants.Any(x => x.Name == currPerformer.Name))
                        {
                            participants
                                .First(x => x.Name == currPerformer.Name)
                                .Awards.Add(input[2]);
                        }
                        else
                        {
                            participants.Add(currPerformer);
                        }
                    }
                }
            }
        }
    }
}
