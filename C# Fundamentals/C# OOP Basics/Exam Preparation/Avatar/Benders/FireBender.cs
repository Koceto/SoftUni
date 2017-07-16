public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double aggression) : base(name, power)
    {
        this.HeatAggression = aggression;
    }

    public double HeatAggression
    {
        get { return this.heatAggression; }
        set { this.heatAggression = value; }
    }

    public override double TotalPower()
    {
        return this.Power * this.HeatAggression;
    }

    public override string BenderSpecialty()
    {
        return $"Heat Aggression: {this.HeatAggression:f2}";
    }
}