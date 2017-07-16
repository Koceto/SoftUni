public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double clarity) : base(name, power)
    {
        this.WaterClarity = clarity;
    }

    public double WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }

    public override double TotalPower()
    {
        return this.Power * this.WaterClarity;
    }

    public override string BenderSpecialty()
    {
        return $"Water Clarity: {this.WaterClarity:f2}";
    }
}