public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double integrity) : base(name, power)
    {
        this.AerialIntegrity = integrity;
    }

    public double AerialIntegrity
    {
        get { return this.aerialIntegrity; }
        set { this.aerialIntegrity = value; }
    }

    public override double TotalPower()
    {
        return this.Power * this.AerialIntegrity;
    }

    public override string BenderSpecialty()
    {
        return $"Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}