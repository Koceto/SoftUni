public abstract class Car : ICar
{
    protected Car(string model, string driver)
    {
        this.Model = model;
        this.Driver = driver;
    }

    public string Driver { get; private set; }
    public string Model { get; protected set; }

    public string Accelerate()
    {
        return "Zadu6avam sA!";
    }

    public string Brake()
    {
        return "Brakes!";
    }
}