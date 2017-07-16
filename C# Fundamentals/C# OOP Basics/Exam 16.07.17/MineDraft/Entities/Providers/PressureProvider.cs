using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        this.EnergyOutput += this.EnergyOutput * 50 / 100;
    }

    public override string Info()
    {
        return $"Pressure Provider - {this.ID}";
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"Pressure Provider - {this.ID}")
            .AppendLine(base.ToString());

        return info.ToString().Trim();
    }
}