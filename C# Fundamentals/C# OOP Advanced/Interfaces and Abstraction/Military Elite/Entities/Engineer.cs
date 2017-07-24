using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string firstName, string lastName, double salary, string corps, List<Work> works) : base(id, firstName, lastName, salary, corps)
    {
        this.Works = works;
    }

    public List<Work> Works { get; }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine(base.ToString())
            .AppendLine("Repairs:");

        foreach (var work in this.Works)
        {
            info.AppendLine($"  {work}");
        }

        return info.ToString().Trim();
    }
}