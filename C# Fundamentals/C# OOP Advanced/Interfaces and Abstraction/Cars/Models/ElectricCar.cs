using System.Text;

public abstract class ElectricCar : Car, IElectricCar
{
    public ElectricCar(string model, string color, int battery)
        : base(model, color)
    {
        this.Battery = battery;
    }

    public int Battery { get; private set; }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries")
            .AppendLine(this.Start())
            .AppendLine(this.Stop());

        return info.ToString().Trim();
    }
}