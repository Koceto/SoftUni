using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += this.OreOutput * 200 / 100;
        this.EnergyRequirement = this.EnergyRequirement * 2;
    }

    public override string ToString()
    {

        StringBuilder info = new StringBuilder();

        info.AppendLine($"Hammer Harvester - {this.ID}")
            .AppendLine(base.ToString());

        return info.ToString().Trim();
    }

    public override string Info()
    {
        return $"Hammer Harvester - {this.ID}";
    }
}