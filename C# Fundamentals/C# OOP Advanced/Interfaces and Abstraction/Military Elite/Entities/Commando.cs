using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string id, string firstName, string lastName, double salary, string corps, List<Mission> missions) : base(id, firstName, lastName, salary, corps)
    {
        this.Missions = missions;
    }

    public List<Mission> Missions { get; private set; }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine(base.ToString())
            .AppendLine("Missions:");

        foreach (var mission in this.Missions)
        {
            info.AppendLine($"  {mission}");
        }

        return info.ToString().Trim();
    }
}