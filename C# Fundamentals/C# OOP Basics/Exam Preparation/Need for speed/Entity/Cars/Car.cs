using System.Text;

public abstract class Car
{
    protected string brand;
    protected string model;
    protected int yearOfProduction;
    protected int horsepower;
    protected int acceleration;
    protected int suspension;
    protected int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}")
            .AppendLine($"{this.horsepower} HP, 100 m/h in {this.acceleration} s")
            .AppendLine($"{this.suspension} Suspension force, {this.durability} Durability");

        return info.ToString();
    }

    public virtual void Tune(int tuneIndex, string part)
    {
        this.horsepower += tuneIndex;
        this.suspension += tuneIndex * 50 / 100;
    }

    public int OverallPerformance()
    {
        return this.EnginePerformance() + this.SuspensionPerformance();
    }

    public int EnginePerformance()
    {
        return this.horsepower / this.acceleration;
    }

    public int SuspensionPerformance()
    {
        return this.suspension + this.durability;
    }

    public string Info()
    {
        return $"{this.brand} {this.model}";
    }
}