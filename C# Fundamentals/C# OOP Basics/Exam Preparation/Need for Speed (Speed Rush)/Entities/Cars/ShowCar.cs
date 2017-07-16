using System.Text;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
    }

    public int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        this.Stars += tuneIndex;
        base.Tune(tuneIndex, addOn);
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine(base.ToString())
            .AppendLine($"{this.Stars} *");

        return info.ToString().Trim();
    }
}