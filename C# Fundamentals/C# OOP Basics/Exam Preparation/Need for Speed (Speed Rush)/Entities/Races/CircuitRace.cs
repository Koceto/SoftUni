using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps) : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    public int Laps
    {
        get { return this.laps; }
        private set { this.laps = value; }
    }

    public override int GetPerformancePoints(Car car)
    {
        return car.OverallPerformance();
    }

    public override string Start()
    {
        StringBuilder results = new StringBuilder();
        Dictionary<Car, int> carsAndScores = new Dictionary<Car, int>();
        List<int> prizes = GetPrizes();

        results.AppendLine($"{this.Route} - {this.Length * this.Laps}");

        for (int i = 0; i < this.Laps; i++)
        {
            this.Participants.ForEach(p => p.RaceWear(this.Length * this.Length));
        }

        carsAndScores = GetWinners();
        int top = Math.Min(4, carsAndScores.Count);

        for (int i = 0; i < top; i++)
        {
            KeyValuePair<Car, int> car = carsAndScores.ElementAtOrDefault(i);
            results.AppendLine($"{i + 1}. {car.Key.Brand} {car.Key.Model} {car.Value}PP - ${prizes[i]}");
        }

        this.RaceEnded();

        return results.ToString().Trim();
    }

    public override List<int> GetPrizes()
    {
        List<int> prizes = new List<int>();

        prizes.Add(this.PrizePool * 40 / 100);
        prizes.Add(this.PrizePool * 30 / 100);
        prizes.Add(this.PrizePool * 20 / 100);
        prizes.Add(this.PrizePool * 10 / 100);

        return prizes;
    }

    public override Dictionary<Car, int> GetWinners()
    {
        Dictionary<Car, int> carsAndScores = new Dictionary<Car, int>();

        foreach (var car in this.Participants)
        {
            carsAndScores.Add(car, GetPerformancePoints(car));
        }

        return carsAndScores.OrderByDescending(w => w.Value).ToDictionary(k => k.Key, v => v.Value);
    }
}