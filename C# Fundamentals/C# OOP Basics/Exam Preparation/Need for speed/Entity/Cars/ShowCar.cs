using System.Text;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder(base.ToString());

        info.Append($"{this.stars} *");

        return info.ToString().Trim();
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        stars += tuneIndex;
        base.Tune(tuneIndex, addOn);
    }
}