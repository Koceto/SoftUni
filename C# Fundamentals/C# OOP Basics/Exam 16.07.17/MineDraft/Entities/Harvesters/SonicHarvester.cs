using System.Text;

public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement /= this.SonicFactor;
    }

    public int SonicFactor
    {
        get { return this.sonicFactor; }
        set { this.sonicFactor = value; }
    }

    public override string Info()
    {
        return $"Sonic Harvester - {this.ID}";
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"Sonic Harvester - {this.ID}")
            .AppendLine(base.ToString());

        return info.ToString().Trim();
    }
}