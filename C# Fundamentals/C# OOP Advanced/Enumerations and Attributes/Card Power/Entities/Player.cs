using System.Collections.Generic;
using System.Linq;

public class Player
{
    private string name;
    private List<Card> cards;

    public Player(string name)
    {
        this.Name = name;
        this.cards = new List<Card>();
    }

    public IReadOnlyList<Card> Cards
    {
        get { return this.cards.AsReadOnly(); }
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public Card StrongestCard { get { return this.Cards.Max(); } }

    public void Add(Card card)
    {
        this.cards.Add(card);
    }
}