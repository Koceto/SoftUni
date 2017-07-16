public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power, double saturation) : base(name, power)
    {
        this.GroundSaturation = saturation;
    }

    public double GroundSaturation
    {
        get { return this.groundSaturation; }
        set { this.groundSaturation = value; }
    }

    public override double TotalPower()
    {
        return this.Power * this.GroundSaturation;
    }

    public override string BenderSpecialty()
    {
        return $"Ground Saturation: {this.GroundSaturation:f2}";
    }
}