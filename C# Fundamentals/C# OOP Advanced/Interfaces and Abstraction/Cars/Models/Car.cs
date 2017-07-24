using System.Text;

public abstract class Car : ICar
{
    protected Car(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Model { get; private set; }
    public string Color { get; private set; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}")
            .AppendLine(this.Start())
            .AppendLine(this.Stop());

        return info.ToString().Trim();
    }
}