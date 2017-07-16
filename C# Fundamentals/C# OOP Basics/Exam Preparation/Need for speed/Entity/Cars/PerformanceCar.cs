using System.Collections.Generic;
using System.Text;

internal class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.horsepower += this.horsepower * 50 / 100;
        this.suspension -= this.suspension * 25 / 100;
        addOns = new List<string>();
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.Append(base.ToString())
            .Append("Add-ons: ");

        if (this.addOns.Count == 0)
        {
            info.Append("None");
        }
        else
        {
            info.Append(string.Join(", ", this.addOns));
        }

        return info.ToString().Trim();
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.addOns.Add(addOn);
    }
}