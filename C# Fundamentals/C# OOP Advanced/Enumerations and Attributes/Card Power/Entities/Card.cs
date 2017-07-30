using System;

public class Card : IComparable<Card>
{
    private string rank;
    private string suit;

    public Card(string value, string suits)
    {
        this.Rank = value;
        this.Suit = suits;
    }

    public string Suit
    {
        get { return this.suit; }
        private set { this.suit = value; }
    }

    public string Rank
    {
        get { return this.rank; }
        private set { this.rank = value; }
    }

    public int Power
    {
        get { return this.GetPower(); }
    }

    private int GetPower()
    {
        int type = (int)Enum.Parse(typeof(CardSuits), this.Suit);
        int value = (int)Enum.Parse(typeof(CardRanks), this.Rank);

        return type + value;
    }

    public override string ToString()
    {
        return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.Power}";
    }

    public int CompareTo(Card other)
    {
        if (this.Power > other.Power)
        {
            return 1;
        }

        if (this.Power < other.Power)
        {
            return -1;
        }

        return 0;
    }
}