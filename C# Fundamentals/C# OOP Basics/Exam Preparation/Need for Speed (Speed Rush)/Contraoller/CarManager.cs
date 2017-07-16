using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;
    private RaceFactory raceFactory;
    private CarFactory carFactory;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
        this.raceFactory = new RaceFactory();
        this.carFactory = new CarFactory();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        Car newCar = carFactory.Create(type, brand, model, yearOfProduction, horsepower, acceleration, suspension,
            durability);

        this.cars.Add(id, newCar);
    }

    public string Check(int id)
    {
        return this.cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool, int specialRaceModifier)
    {
        Race newRace = raceFactory.Create(type, length, route, prizePool, specialRaceModifier);

        this.races.Add(id, newRace);
    }

    public void Participate(int carId, int raceId)
    {
        Car car = this.cars.FirstOrDefault(c => c.Key == carId).Value;
        Race race = this.races.FirstOrDefault(r => r.Key == raceId).Value;

        if (!garage.IsParked(car) && race.IsOpen)
        {
            race.Register(car);
        }
    }

    public string Start(int id)
    {
        Race race = this.races[id];

        if (race.Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }

        if (race.IsOpen)
        {
            return race.Start();
        }

        throw new ArgumentException($"Race {id} cannot be Re-Opened");
    }

    public void Park(int id)
    {
        Car car = this.cars[id];

        bool IsCarParticipatingInAnyActiveRace = this.races.Any(r => r.Value.IsOpen && r.Value.IsParticipating(car));

        if (!IsCarParticipatingInAnyActiveRace)
        {
            this.garage.Park(car);
        }
    }

    public void Unpark(int id)
    {
        Car car = this.cars[id];

        this.garage.UnPark(car);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        this.garage.Tune(tuneIndex, addOn);
    }
}