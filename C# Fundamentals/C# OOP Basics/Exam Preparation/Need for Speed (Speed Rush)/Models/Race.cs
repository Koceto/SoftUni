using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;
    private bool isOpen;

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new List<Car>();
        this.IsOpen = true;
    }

    public List<Car> Participants
    {
        get { return this.participants; }
        private set { this.participants = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        private set { this.prizePool = value; }
    }

    public string Route
    {
        get { return this.route; }
        private set { this.route = value; }
    }

    public int Length
    {
        get { return this.length; }
        private set { this.length = value; }
    }

    public bool IsOpen
    {
        get { return this.isOpen; }
        private set { this.isOpen = value; }
    }

    public virtual void Register(Car car)
    {
        this.Participants.Add(car);
    }

    public bool IsParticipating(Car car)
    {
        return this.Participants.Contains(car);
    }

    public abstract int GetPerformancePoints(Car car);

    public virtual string Start()
    {
        StringBuilder raceInfo = new StringBuilder();
        Dictionary<Car, int> carsAndScores = GetWinners();
        List<int> prizes = GetPrizes();

        RaceEnded();

        raceInfo.AppendLine($"{this.Route} - {this.Length}");

        for (int i = 0; i < carsAndScores.Count; i++)
        {
            KeyValuePair<Car, int> car = carsAndScores.ElementAtOrDefault(i);

            raceInfo.AppendLine($"{i + 1}. {car.Key.Brand} {car.Key.Model} {car.Value}PP - ${prizes[i]}");
        }

        return raceInfo.ToString().Trim();
    }

    public void RaceEnded()
    {
        this.IsOpen = false;
    }

    public virtual List<int> GetPrizes()
    {
        List<int> prizes = new List<int>();

        prizes.Add(this.PrizePool * 50 / 100);
        prizes.Add(this.prizePool * 30 / 100);
        prizes.Add(this.prizePool * 20 / 100);

        return prizes;
    }

    public virtual Dictionary<Car, int> GetWinners()
    {
        Dictionary<Car, int> winners = new Dictionary<Car, int>();

        foreach (var car in this.Participants)
        {
            winners.Add(car, GetPerformancePoints(car));
        }

        int top = Math.Min(3, this.Participants.Count);

        return winners.OrderByDescending(c => c.Value).Take(top).ToDictionary(x => x.Key, x => x.Value);
    }
}