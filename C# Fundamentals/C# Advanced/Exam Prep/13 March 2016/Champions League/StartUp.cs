using System;
using System.Collections.Generic;
using System.Linq;

namespace Champions_League
{
    public static class StartUp
    {
        public static void Main()
        {
            List<Team> allTeams = new List<Team>();
            string input;

            while ((input = Console.ReadLine().Trim()) != "stop")
            {
                string[] data = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string firstTeam = data[0];
                string secondTeam = data[1];
                int[] firstMatchResults = data[2].Split(':').Select(int.Parse).ToArray();
                int[] secondMatchResult = data[3].Split(':').Select(int.Parse).ToArray();
                bool hasFirstTeamWon;

                int firstTeamScore = firstMatchResults[0] + secondMatchResult[1];
                int secondTeamScore = firstMatchResults[1] + secondMatchResult[0];

                if (firstTeamScore > secondTeamScore)
                {
                    hasFirstTeamWon = true;
                }
                else if (firstTeamScore < secondTeamScore)
                {
                    hasFirstTeamWon = false;
                }
                else
                {
                    int firstTeamAwaiSoilGoals = secondMatchResult[1];
                    int secondTeamAwaiSoilGoals = firstMatchResults[1];

                    if (firstTeamAwaiSoilGoals > secondTeamAwaiSoilGoals)
                    {
                        hasFirstTeamWon = true;
                    }
                    else
                    {
                        hasFirstTeamWon = false;
                    }
                }

                Team first = new Team
                {
                    Name = firstTeam,
                    Opponents = new SortedSet<string> { secondTeam }
                };

                Team second = new Team
                {
                    Name = secondTeam,
                    Opponents = new SortedSet<string> { firstTeam }
                };

                if (hasFirstTeamWon)
                {
                    first.Wins++;
                }
                else
                {
                    second.Wins++;
                }

                Team firstToModify = allTeams.FirstOrDefault(t => t.Name == firstTeam);

                if (firstToModify != null)
                {
                    firstToModify.Wins += first.Wins;
                    firstToModify.Opponents.Add(first.Opponents.First());
                }
                else
                {
                    allTeams.Add(first);
                }

                Team secondToModify = allTeams.FirstOrDefault(t => t.Name == secondTeam);

                if (secondToModify != null)
                {
                    secondToModify.Wins += second.Wins;
                    secondToModify.Opponents.Add(second.Opponents.First());
                }
                else
                {
                    allTeams.Add(second);
                }
            }

            foreach (var team in allTeams.OrderByDescending(t => t.Wins).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- Wins: {team.Wins}");
                Console.WriteLine($"- Opponents: {string.Join(", ", team.Opponents)}");
            }
        }
    }
}