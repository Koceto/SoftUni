using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<ISoldier> privates) : base(id, firstName, lastName, salary)
    {
        this.Privates = privates;
    }

    public List<ISoldier> Privates { get; private set; }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine(base.ToString())
            .AppendLine("Privates:");

        foreach (var soldier in this.Privates)
        {
            info.AppendLine($"  {soldier}");
        }

        return info.ToString().Trim();
    }
}