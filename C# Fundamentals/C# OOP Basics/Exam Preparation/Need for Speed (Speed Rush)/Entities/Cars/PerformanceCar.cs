using System;
using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<String> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        PerformanceBonus();
    }

    public List<String> AddOns
    {
        get { return this.addOns; }
        set { this.addOns = value; }
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        this.AddOns.Add(addOn);
        base.Tune(tuneIndex, addOn);
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine(base.ToString());
        info.AppendLine($"Add-ons: {GetAddons()}");

        return info.ToString().Trim();
    }

    public void PerformanceBonus()
    {
        this.Horsepower += this.Horsepower * 50 / 100;
        this.Suspension -= this.Suspension * 25 / 100;
    }

    private string GetAddons()
    {
        if (this.AddOns.Count > 0)
        {
            return string.Join(", ", this.AddOns);
        }
        return "None";
    }
}