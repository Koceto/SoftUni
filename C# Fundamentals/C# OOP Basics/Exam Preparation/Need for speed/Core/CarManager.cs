using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> allCars;
    private Dictionary<int, Race> allRaces;
    private Garage garage;

    public CarManager()
    {
        this.allCars = new Dictionary<int, Car>();
        this.allRaces = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        Car newCar = null;

        if (type == "Performance")
        {
            newCar = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration,
                suspension, durability);
        }
        else
        {
            newCar = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        }

        this.allCars.Add(id, newCar);
    }

    public string Check(int id)
    {
        return this.allCars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race newRace = null;

        if (type == "Casual")
        {
            newRace = new CasualRace(length, route, prizePool);
        }
        else if (type == "Drag")
        {
            newRace = new DragRace(length, route, prizePool);
        }
        else
        {
            newRace = new DriftRace(length, route, prizePool);
        }

        this.allRaces.Add(id, newRace);
    }

    public void Participate(int carId, int raceId)
    {
        Car currentCar = this.allCars[carId];

        if (!this.garage.IsParked(currentCar))
        {
            if (this.allRaces.ContainsKey(raceId))
            {
                Race currentRace = this.allRaces[raceId];

                currentRace.AddParticipant(carId, currentCar);
            }
        }
    }

    public string Start(int id)
    {
        string results = String.Empty;

        if (this.allRaces.ContainsKey(id))
        {
            Race currentRace = this.allRaces[id];

            if (currentRace.Participants.Count == 0)
            {
                results = "Cannot start the race with zero participants.";
            }
            else
            {
                results = currentRace.Start();
                this.allRaces.Remove(id);
            }
        }

        return results;
    }

    public void Park(int id)
    {
        Car currentCar = this.allCars[id];

        if (!allRaces.Any(r => r.Value.IsRegistered(currentCar)))
        {
            garage.Park(currentCar);
        }
    }

    public void Unpark(int id)
    {
        Car currentCar = this.allCars[id];
        garage.Unpark(currentCar);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        garage.Tune(tuneIndex, addOn);
    }
}