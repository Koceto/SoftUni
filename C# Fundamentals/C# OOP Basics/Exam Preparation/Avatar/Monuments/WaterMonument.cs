public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int affinity) : base(name)
    {
        this.WaterAffinity = affinity;
    }

    public int WaterAffinity
    {
        get { return this.waterAffinity; }
        set { this.waterAffinity = value; }
    }

    public override int GetPower()
    {
        return this.WaterAffinity;
    }
    public override string GetSpecialty()
    {
        return $"Water Affinity: {this.WaterAffinity}";
    }
}