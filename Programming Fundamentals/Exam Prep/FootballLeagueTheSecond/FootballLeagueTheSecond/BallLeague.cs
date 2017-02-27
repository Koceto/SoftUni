namespace FootballLeagueTheSecond
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamScore
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public int Goals { get; set; }
    }

    public class BallLeague
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var allTeams = new List<TeamScore>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input.First().ToLower() == "final")
                {
                    break;
                }

                // FIRST TEAM
                var firstTeamStartingIndex = input
                    .First()
                    .IndexOf(key);
                var firstTeamEndIndex = input
                     .First()
                     .LastIndexOf(key);
                var firstTeam = input.First().Substring(firstTeamStartingIndex + key.Length, firstTeamEndIndex - (firstTeamStartingIndex + key.Length));
                var firstTeamGoals = input
                    .Last()
                    .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .First();
                var firstTeamPoints = default(int);

                firstTeam = string.Join("", firstTeam.ToCharArray().Reverse()).ToUpper();

                // SECOND TEAM
                var secondTeamStartingIndex = input[1].IndexOf(key);
                var secondTeamEndIndex = input[1].LastIndexOf(key);
                var secondTeam = input[1].Substring(secondTeamStartingIndex + key.Length, secondTeamEndIndex - (secondTeamStartingIndex + key.Length));
                var secondTeamGoals = input
                     .Last()
                     .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .Last();
                var secondTeamPoints = default(int);

                secondTeam = string.Join("", secondTeam.ToCharArray().Reverse()).ToUpper();


                // SCORES
                if (firstTeamGoals > secondTeamGoals)
                {
                    firstTeamPoints = 3;
                }
                else if (secondTeamGoals > firstTeamGoals)
                {
                    secondTeamPoints = 3;
                }
                else
                {
                    firstTeamPoints = 1;
                    secondTeamPoints = 1;
                }

                /// FIRST TEAM
                if (allTeams.Any(t => t.Name == firstTeam))
                {
                    allTeams.Find(t => t.Name == firstTeam).Goals += firstTeamGoals;
                    allTeams.Find(t => t.Name == firstTeam).Points += firstTeamPoints;
                }
                else
                {
                    allTeams.Add(new TeamScore
                    {
                        Goals = firstTeamGoals,
                        Name = firstTeam,
                        Points = firstTeamPoints
                    });
                }
                // SECOND TEAM
                if (allTeams.Any(t => t.Name == secondTeam))
                {
                    allTeams.Find(t => t.Name == secondTeam).Goals += secondTeamGoals;
                    allTeams.Find(t => t.Name == secondTeam).Points += secondTeamPoints;
                }
                else
                {
                    allTeams.Add(new TeamScore
                    {
                        Goals = secondTeamGoals,
                        Name = secondTeam,
                        Points = secondTeamPoints
                    });
                }
            }

            var top = allTeams
                .OrderByDescending(t => t.Goals)
                .ThenBy(t => t.Name)
                .Take(3)
                .ToList();
            var counter = 1;

            Console.WriteLine("League standings:");

            foreach (var team in allTeams.OrderByDescending(t => t.Points).ThenBy(t => t.Name))
            {
                Console.WriteLine($"{counter}. {team.Name} {team.Points}");

                counter++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in top)
            {
                Console.WriteLine($"- {team.Name} -> {team.Goals}");
            }
        }
    }
}
