using System.Text;

public class SolarProvider : Provider
{
    public SolarProvider(string id, double energyOutput) : base(id, energyOutput)
    {
    }

    public override string Info()
    {
        return $"Solar Provider - {this.ID}";
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"Solar Provider - {this.ID}")
            .AppendLine(base.ToString());

        return info.ToString().Trim();
    }
}