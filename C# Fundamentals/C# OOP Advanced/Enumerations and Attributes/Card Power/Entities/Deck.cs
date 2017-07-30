using System.Collections.Generic;

public class Deck
{
    private List<Card> cards;

    public Deck()
    {
        this.cards = new List<Card>();
    }

    public IReadOnlyList<Card> Cards
    {
        get { return this.cards.AsReadOnly(); }
    }

    public void Add(Card card)
    {
        this.cards.Add(card);
    }
}