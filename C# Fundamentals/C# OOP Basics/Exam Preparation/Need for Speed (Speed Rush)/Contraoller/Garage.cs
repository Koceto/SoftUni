using System.Collections.Generic;

public class Garage
{
    private List<Car> parkedCars;

    public Garage()
    {
        this.ParkedCars = new List<Car>();
    }

    public List<Car> ParkedCars
    {
        get { return this.parkedCars; }
        private set { this.parkedCars = value; }
    }

    public bool IsParked(Car car)
    {
        return this.ParkedCars.Contains(car);
    }

    public void Park(Car car)
    {
        this.ParkedCars.Add(car);
    }

    public void UnPark(Car car)
    {
        this.ParkedCars.Remove(car);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in this.ParkedCars)
        {
            car.Tune(tuneIndex, addOn);
        }
    }
}