public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int affinity) : base(name)
    {
        this.FireAffinity = affinity;
    }

    public int FireAffinity
    {
        get { return this.fireAffinity; }
        set { this.fireAffinity = value; }
    }

    public override int GetPower()
    {
        return this.FireAffinity;
    }
    public override string GetSpecialty()
    {
        return $"Fire Affinity: {this.FireAffinity}";
    }
}