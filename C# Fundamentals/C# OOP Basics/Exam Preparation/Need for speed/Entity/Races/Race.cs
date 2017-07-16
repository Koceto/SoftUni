using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    protected int length;
    protected string route;
    protected int prizePool;
    protected Dictionary<int, Car> participants;
    protected int firstPlacePrize;
    protected int secondPlacePrize;
    protected int thirdPlacePrize;
    private Dictionary<Car, int> winners;

    protected Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new Dictionary<int, Car>();
        this.winners = new Dictionary<Car, int>();
    }

    public abstract int GetPerformance(int id);

    public void AddParticipant(int id, Car car)
    {
        participants.Add(id, car);
    }

    public IList<Car> Participants
    {
        get
        {
            return this.participants.Values.ToList().AsReadOnly();
        }
    }

    public bool IsRegistered(Car car)
    {
        return participants.ContainsValue(car);
    }

    public IList<int> PrizeList()
    {
        List<int> prizes = new List<int>();

        prizes.Add(prizePool / 2);
        prizes.Add(prizePool * 30 / 100);
        prizes.Add(prizePool * 20 / 100);

        return prizes.AsReadOnly();
    }

    public string Start()
    {
        StringBuilder results = new StringBuilder();

        results.AppendLine($"{this.route} - {this.length}");

        foreach (var participant in this.participants)
        {
            this.winners.Add(participant.Value, GetPerformance(participant.Key));
        }

        winners = winners.OrderByDescending(p => p.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        int topParticipantsCount = Math.Min(3, this.participants.Count);

        for (int i = 0; i < topParticipantsCount; i++)
        {
            var currentPrint = winners.ElementAt(i);

            results.AppendLine($"{i + 1}. {currentPrint.Key.Info()} {currentPrint.Value}PP - ${this.PrizeList()[i]}");
        }

        return results.ToString().Trim();
    }
}