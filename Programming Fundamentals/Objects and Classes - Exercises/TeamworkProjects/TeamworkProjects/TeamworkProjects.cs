using System;
using System.Collections.Generic;
using System.Linq;

public class Teams
{
    public string Name { get; set; }

    public string Creator { get; set; }

    public List<string> Users { get; set; }
}

namespace TeamworkProjects
{
    public class TeamworkProjects
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var teams = new List<Teams>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split('-');
                var tempTeam = new Teams();
                tempTeam.Creator = input[0];
                tempTeam.Name = input[1];
                tempTeam.Users = new List<string>();

                if (teams.Any(t => t.Name == tempTeam.Name))
                {
                    Console.WriteLine($"Team {tempTeam.Name} was already created!");
                }
                else if (teams.Any(c => c.Creator == tempTeam.Creator))
                {
                    Console.WriteLine($"{tempTeam.Creator} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {tempTeam.Name} has been created by {tempTeam.Creator}!");
                    teams.Add(tempTeam);
                }
            }

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end of assignment")
                {
                    break;
                }
                var currUser = input[0];
                var currTeam = input[1];

                if (teams.All(k => k.Name != currTeam))
                {
                    Console.WriteLine($"Team {currTeam} does not exist!");
                }
                else if (teams.Any(v => v.Users.Contains(currUser)) || teams.Any(k => k.Creator == currUser))
                {
                    Console.WriteLine($"Member {currUser} cannot join team {currTeam}!");
                }
                else
                {
                    teams.First(d => d.Name == currTeam).Users.Add(currUser);
                }

            }
            var teamsWhitMembes = teams
                .Where(m => m.Users.Count > 0)
                .ToList();
            var teamsWhitNoMembers = teams
                .Where(s => s.Users.Count == 0)
                .ToList();



            foreach (var team in teamsWhitMembes.OrderByDescending(j => j.Users.Count()).ThenBy(b => b.Name).ToList())
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);
                foreach (var member in team.Users.OrderBy(o => o).ToList())
                {
                    Console.WriteLine("-- " + member);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsWhitNoMembers.OrderBy(m => m.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}