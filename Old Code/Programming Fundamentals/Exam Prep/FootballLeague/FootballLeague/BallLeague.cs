namespace FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Team
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public int Goals { get; set; }
    }

    public class BallLeague
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var regex = new Regex($"[{key}]\\w+[{key}]");
            var leagueResults = new List<Team>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "final")
                {
                    break;
                }

                var Teams = regex.Matches(input);
                var matchResult = input
                    .Split(' ')
                    .Last()
                    .Split(':')
                    .ToArray();
                var temp = input.Split(' ');
                var firstTeam = GetTeamName(temp[0], key);
                var secondTeam = GetTeamName(temp[1], key);

                var firstTeamGoals = int.Parse(matchResult[0]);
                var secondTeamGoals = int.Parse(matchResult[1]);
                var teamA = new Team
                {
                    Name = firstTeam,
                    Goals = firstTeamGoals
                };
                var teamB = new Team
                {
                    Name = secondTeam,
                    Goals = secondTeamGoals
                };

                if (firstTeamGoals > secondTeamGoals)
                {
                    teamA.Score = 3;
                }
                else if (secondTeamGoals > firstTeamGoals)
                {
                    teamB.Score = 3;
                }
                else
                {
                    teamA.Score = 1;
                    teamB.Score = 1;
                }

                if (leagueResults.Any(t => t.Name == teamA.Name))
                {
                    leagueResults.First(t => t.Name == teamA.Name).Goals += teamA.Goals;
                    leagueResults.First(t => t.Name == teamA.Name).Score += teamA.Score;
                }
                else
                {
                    leagueResults.Add(teamA);
                }

                if (leagueResults.Any(t => t.Name == teamB.Name))
                {
                    leagueResults.First(t => t.Name == teamB.Name).Goals += teamB.Goals;
                    leagueResults.First(t => t.Name == teamB.Name).Score += teamB.Score;
                }
                else
                {
                    leagueResults.Add(teamB);
                }
            }
            var counter = 1;

            Console.WriteLine("League standings:");

            foreach (var team in leagueResults.OrderByDescending(t => t.Score).ThenBy(t => t.Name))
            {
                Console.WriteLine($"{counter}. {team.Name} {team.Score}");
                counter++;
            }
            Console.WriteLine("Top 3 scored goals:");

            counter = 1;
            foreach (var team in leagueResults.OrderByDescending(t => t.Goals).ThenBy(t => t.Name))
            {
                if (counter > 3)
                {
                    break;
                }

                Console.WriteLine($"- {team.Name} -> {team.Goals}");

                counter++;
            }
        }

        private static string GetTeamName(string teamName, string key)
        {
            var firstIndex = teamName.IndexOf(key) + key.Length;
            var secondIndex = teamName.LastIndexOf(key);
            var length = secondIndex - firstIndex;
            var name = teamName.Substring(firstIndex, length);

            return string.Join("", name.ToUpper().Reverse());
        }
    }
}
