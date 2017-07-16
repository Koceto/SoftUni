using System.Collections.Generic;

public class Garage
{
    private List<Car> parkedCars = new List<Car>();

    public void Park(Car car)
    {
        parkedCars.Add(car);
    }

    public void Unpark(Car car)
    {
        parkedCars.Remove(car);
    }

    public bool IsParked(Car car)
    {
        return parkedCars.Contains(car);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in this.parkedCars)
        {
            car.Tune(tuneIndex, addOn);
        }
    }
}