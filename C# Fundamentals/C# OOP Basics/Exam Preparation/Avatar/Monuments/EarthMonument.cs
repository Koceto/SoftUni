public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int affinity) : base(name)
    {
        this.EarthAffinity = affinity;
    }

    public int EarthAffinity
    {
        get { return this.earthAffinity; }
        set { this.earthAffinity = value; }
    }

    public override int GetPower()
    {
        return this.EarthAffinity;
    }
    public override string GetSpecialty()
    {
        return $"Earth Affinity: {this.EarthAffinity}";
    }
}