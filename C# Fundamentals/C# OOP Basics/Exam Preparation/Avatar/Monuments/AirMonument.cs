public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int affinity) : base(name)
    {
        this.AirAffinity = affinity;
    }

    public int AirAffinity
    {
        get { return this.airAffinity; }
        set { this.airAffinity = value; }
    }

    public override int GetPower()
    {
        return this.AirAffinity;
    }

    public override string GetSpecialty()
    {
        return $"Air Affinity: {this.AirAffinity}";
    }
}