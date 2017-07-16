using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public int Durability
    {
        get { return this.durability; }
        private set { this.durability = value; }
    }

    public int Suspension
    {
        get { return this.suspension; }
        protected set { this.suspension = value; }
    }

    public int Acceleration
    {
        get { return this.acceleration; }
        private set { this.acceleration = value; }
    }

    public int Horsepower
    {
        get { return this.horsepower; }
        protected set { this.horsepower = value; }
    }

    public int YearOfProduction
    {
        get { return this.yearOfProduction; }
        private set { this.yearOfProduction = value; }
    }

    public string Model
    {
        get { return this.model; }
        private set { this.model = value; }
    }

    public string Brand
    {
        get { return this.brand; }
        private set { this.brand = value; }
    }

    public int OverallPerformance()
    {
        return EnginePerformance() + SuspensionPerformance();
    }

    public int EnginePerformance()
    {
        return this.Horsepower / this.Acceleration;
    }

    public int SuspensionPerformance()
    {
        return this.Suspension + this.Durability;
    }

    public int TimePerformance()
    {
        return this.Horsepower / 100 * this.Acceleration;
    }

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.Horsepower += tuneIndex;
        this.Suspension += tuneIndex / 2;
    }

    public void RaceWear(int raceWear)
    {
        this.Durability -= raceWear;
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}")
            .AppendLine($"{this.Horsepower} HP, 100 m/h in {this.Acceleration} s")
            .AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");

        return info.ToString().Trim();
    }
}