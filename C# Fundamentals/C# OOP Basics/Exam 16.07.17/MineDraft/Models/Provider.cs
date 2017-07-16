using System;
using System.Text;

public abstract class Provider : Robot
{
    private double energyOutput;

    public Provider(string id, double energyOutput)
        :base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"Energy Output: {this.EnergyOutput}");

        return info.ToString();
    }

    public abstract string Info();
}