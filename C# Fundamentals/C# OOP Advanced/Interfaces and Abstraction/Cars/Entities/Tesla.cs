public class Tesla : ElectricCar, IElectricCar
{
    public Tesla(string model, string color, int battery)
        : base(model, color, battery)
    {
    }
}