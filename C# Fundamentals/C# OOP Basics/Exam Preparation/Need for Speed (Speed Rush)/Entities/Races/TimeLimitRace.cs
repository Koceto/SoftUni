using System;
using System.Linq;
using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;

    public TimeLimitRace(int length, string route, int prizePool, int goldTime) : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }

    public int GoldTime
    {
        get { return this.goldTime; }
        private set { this.goldTime = value; }
    }

    public override int GetPerformancePoints(Car car)
    {
        return this.Length * car.TimePerformance();
    }

    public override string Start()
    {
        StringBuilder results = new StringBuilder();
        Car car = this.Participants.FirstOrDefault();
        int score = GetPerformancePoints(car);
        string timeResult = String.Empty;
        int prize = default(int);

        results.AppendLine($"{this.Route} - {this.Length}")
            .AppendLine($"{car.Brand} {car.Model} - {score} s.");

        if (score <= this.GoldTime)
        {
            timeResult = "Gold";
            prize = this.PrizePool;
        }
        else if (score <= this.GoldTime + 15)
        {
            timeResult = "Silver";
            prize = this.PrizePool * 50 / 100;
        }
        else if (score > this.GoldTime + 15)
        {
            timeResult = "Bronze";
            prize = this.PrizePool * 30 / 100;
        }

        results.AppendLine($"{timeResult} Time, ${prize}.");
        this.RaceEnded();

        return results.ToString().Trim();
    }

    public override void Register(Car car)
    {
        if (this.Participants.Count == 0)
        {
            base.Register(car);
        }
    }
}